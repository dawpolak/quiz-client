using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizClient
{
    interface IViewQuiz
    {
        string Question { set; }
        event Action<int> GetQuestion;
    }
}
