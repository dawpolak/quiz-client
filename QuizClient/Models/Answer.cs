using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizClient
{
    public class Answer
    {
        public string text;
        public bool isCorrect;
        public Answer() { }
        public Answer(string text, bool isCorrect)
        {
            this.text = text;
            this.isCorrect = isCorrect;
        }
    }
}
