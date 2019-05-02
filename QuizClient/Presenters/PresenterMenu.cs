using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizClient
{
    class Presenter
    {
        IViewMenu view;
        Model model;
        public Presenter(IViewMenu view, Model model)
        {
            this.view = view;
            this.model = model;

            this.view.LoadQuiz += View_LoadQuiz;
        }

        private void View_LoadQuiz(string path)
        {
            model.LoadQuiz(path);
            view.QuizTitle = model.QuizTitle;
        }
    }
}
