using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace QuizClient
{
    public class Model
    {
        private Quiz quiz;
        public uint TotalPoints
        {
            get
            {
                return quiz.totalPoints;
            }
        }
        public string QuizTitle
        {
            get
            {
                return quiz.title;
            }
            set
            {
                quiz.title = value;
            }
        }
        public Model()
        {
            quiz = new Quiz();
        }



        public List<Tuple<string, uint, List<Tuple<string, bool>>>> GetQuestions
        {
            get
            {
                return quiz.GetQuestionTuples();
            }
        }
        #region FormMenu
        public void LoadQuiz(string path)
        {
            string inputJson;
            using (StreamReader inputFile = new StreamReader(Path.Combine(path)))
            {
                inputJson = inputFile.ReadToEnd();
            }

            try
            {
                quiz = new JavaScriptSerializer().Deserialize<Quiz>(inputJson);

            }
            catch (Exception e)
            {
                throw new Exception("Failed to open file");
            }
        }
        #endregion

        #region FormQuiz
        public string GetQuestion(int index)
        {
            return quiz.questions[index].text;
        }

        public Answer[] GetAnswers(int index)
        {
            Console.WriteLine("Zwracam odpowiedz" + quiz.questions[index].answers[0]);
            return quiz.questions[index].answers;
        }

        public int AmountOfQuestions()
        {
            return quiz.questions.Count();
        }

        public double GetCalculatedPoints (int index,bool[] isCorrect)
        {
            double questionPoints=0;
            int amountOfCorrect = 0;
            int i = 0;
            foreach (var item in quiz.questions[index].answers)
            {
                if (item.isCorrect == true) amountOfCorrect++;
            }
            for (i = 0; i < quiz.questions[index].answers.Count(); i++)
            {
                if ((quiz.questions[index].answers[i].isCorrect == isCorrect[i]) && isCorrect[i]) questionPoints += quiz.questions[index].points / Convert.ToDouble(amountOfCorrect); else if(isCorrect[i])break;
            }
            if (i == quiz.questions[index].answers.Count()) return questionPoints; else return 0;
        }
        #endregion
    }
}
