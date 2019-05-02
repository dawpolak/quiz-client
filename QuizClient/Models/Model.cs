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
        #endregion
    }
}
