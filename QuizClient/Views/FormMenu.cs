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
    public partial class FormMenu : Form,IViewMenu
    {
        Model model;
        public FormMenu(Model model)
        {
            InitializeComponent();
            //jako argument przyjmujemy model aby go dalje przekazac do FormQuiz
            //pozwoli to dzialac juz na pobranym quizie przez FormMenu
            this.model = model;
        }

        #region implementacja IView
        public string QuizTitle
        {
            get
            {
                return labelQuizTitle.Text;
            }
            set
            {
                labelQuizTitle.Text = value;
            }
        }
        public event Action<string> LoadQuiz;
        #endregion

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = "JSON files (*.json)|*.json|Txt files (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (LoadQuiz != null)
                    {
                        LoadQuiz(openFileDialog.FileName);
                        buttonStart.Enabled = true;
                    }
                }
            } 
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            FormQuiz f = new FormQuiz();
            PresenterQuiz presenter = new PresenterQuiz(f, model);
            f.Text = QuizTitle;
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
