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
        }


        #region Implementacja IViewQuiz
        public string Question
        {
            set
            {
                labelQuestion.Text = value;
            }
        }
        public event Action<int> GetQuestion;
        #endregion


        private void FormQuiz_Load(object sender, EventArgs e)
        {
            if (GetQuestion != null)
            {
                GetQuestion(0);
            }
            else Console.WriteLine("nulllllllll");
            Button answer = new Button();
            flowLayoutAnswers.Controls.Add(answer);
        }
    }
}
