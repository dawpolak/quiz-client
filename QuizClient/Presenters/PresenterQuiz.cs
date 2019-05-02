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
        }

        private void View_GetQuestion(int index)
        {
            view.Question = model.GetQuestion(0);
        }
    }
}
