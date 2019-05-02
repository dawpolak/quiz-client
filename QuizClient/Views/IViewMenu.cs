using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizClient
{
    interface IViewMenu
    {
        string QuizTitle { get; set; }
        event Action<string> LoadQuiz;
    }
}
