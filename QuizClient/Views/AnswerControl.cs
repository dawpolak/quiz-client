using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizClient
{
    public partial class AnswerControl : UserControl
    {
        private bool isChecked;
        private bool isCorrect;
        public bool IsChecked { get; set; } 
        public bool IsCorrect {
            get
            {
                return isCorrect;
            }

            set
            {
                isCorrect = value;
            }
        } 

        public AnswerControl(Answer answer, int size)
        {
            InitializeComponent();
            this.Width = size-60;
            buttonAnswer.Width = this.Width-5;
            buttonAnswer.Text = answer.text;
            this.IsChecked = false;
            this.IsCorrect = answer.isCorrect;
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            if (IsChecked)
            {
                IsChecked = false;
                this.BackColor = System.Drawing.SystemColors.Control;
                buttonAnswer.BackColor = System.Drawing.SystemColors.Control;
            }
            else
            {
                IsChecked = true;
                this.BackColor = System.Drawing.SystemColors.Highlight;
                buttonAnswer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            }
        }


    }
}
