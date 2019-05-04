using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizClient
{
    public partial class FormQuiz : Form,IViewQuiz
    {
        public FormQuiz()
        {
            InitializeComponent();
            numberOfQuestion = 0;
        }

        #region Properties
        private int numberOfQuestion;
        private int amountOfQuestion;
        private double totalPoints=0;
        #endregion

        #region Implementacja IViewQuiz
        public string Question
        {
            set
            {
                labelQuestion.Text = value;
            }
        }

        public Answer[] Answers
        {

            set
            {
                flowLayoutAnswers.Controls.Clear();
                foreach (Answer ans in value)
                {
                    AnswerControl answer = new AnswerControl(ans,this.Width);
                    flowLayoutAnswers.Controls.Add(answer);
                }
            }
        }
        
        public int AmountOfQuestions
        {

            set
            {
                labelAmountOfQestions.Text = numberOfQuestion+1+"/"+value.ToString();
                amountOfQuestion = value;
            }
        }
        public double TotalPoints
        {
            get
            {
                return totalPoints;
            }
            set
            {
                totalPoints = value;
            }
        }
        public event Action<int> GetQuestion;
        public event Action<int> GetAnswers;
        public event Action<int> NewQuestion;
        public event Action<int,bool[]> CalculatePoints;
        #endregion


        private void FormQuiz_Load(object sender, EventArgs e)
        {
            //GetQuestion?.Invoke(0);
            //GetAnswers?.Invoke(0);
            NewQuestion?.Invoke(numberOfQuestion);

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            bool[] tmpAnswer = new bool[flowLayoutAnswers.Controls.Count];
            int i = 0;
            foreach (AnswerControl control in flowLayoutAnswers.Controls)
            {
                if (control.IsChecked == true) tmpAnswer[i] = true; else tmpAnswer[i] = false;
                i++;
            }
            CalculatePoints?.Invoke(numberOfQuestion,tmpAnswer);

            NewQuestion?.Invoke(++numberOfQuestion);
            
            if (amountOfQuestion == amountOfQuestion)
            {
                buttonNext.Enabled = false;
                buttonFinish.ForeColor = Color.Green;
            }
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            bool[] tmpAnswer = new bool[flowLayoutAnswers.Controls.Count];
            int i = 0;
            foreach (AnswerControl control in flowLayoutAnswers.Controls)
            {
                if (control.IsChecked == true) tmpAnswer[i] = true; else tmpAnswer[i] = false;
                i++;
            }
            CalculatePoints?.Invoke(numberOfQuestion, tmpAnswer);
            MessageBox.Show("Koniec\nWynik: "+TotalPoints);
            this.Close();
        }
    }
}
