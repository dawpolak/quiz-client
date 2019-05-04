using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizClient
{
    class PresenterQuiz
    {
        IViewQuiz view;
        Model model;
        public PresenterQuiz(IViewQuiz view, Model model)
        {
            this.view = view;
            this.model = model;
            view.GetQuestion += View_GetQuestion;
            view.GetAnswers += View_GetAnswers;
            view.NewQuestion += View_NewQuestion;
            view.CalculatePoints += View_CalculatePoints;
        }

        private void View_CalculatePoints(int index,bool[] obj)
        {
            view.TotalPoints += model.GetCalculatedPoints(index,obj);
            Console.WriteLine("Total points"+view.TotalPoints);
        }

        private void View_NewQuestion(int index)
        {
            view.Answers = model.GetAnswers(index);
            view.Question = model.GetQuestion(index);
            view.AmountOfQuestions = model.AmountOfQuestions();

        }

        private void View_GetAnswers(int index)
        {
           view.Answers = model.GetAnswers(index);
        }

        private void View_GetQuestion(int index)
        {
            view.Question = model.GetQuestion(index);
        }
    }
}
