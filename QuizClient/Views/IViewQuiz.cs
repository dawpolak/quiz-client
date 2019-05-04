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
        Answer[] Answers { set; }
        int AmountOfQuestions { set; }
        double TotalPoints { get; set; }
        event Action<int,bool[]> CalculatePoints;
        event Action<int> GetQuestion;
        event Action<int> GetAnswers;
        event Action<int> NewQuestion;

    }
}
