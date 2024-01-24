using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizNania3._0_.Models
{
    internal class Quiz
    {
        private IEnumerable<Question> _questions;
        private string _title = string.Empty;
        public IEnumerable<Question> Questions => _questions;
        public string Title => _title;

        List<int> usedQuestion = new List<int>();

        public Quiz()
        {
            _questions = JSON.GetAllQuizQuestionsJSON();

        }

        public Question GetRandomQuestion(List<Question> listOfAllQuestions)
        {

            bool GameOn = true;
            Random random = new Random();

            while (GameOn)
            {
                int randomIndex = random.Next(0, listOfAllQuestions.Count());

                if (!usedQuestion.Contains(randomIndex))
                {
                    usedQuestion.Add(randomIndex);
                    Question randomQuestion = listOfAllQuestions[randomIndex];

                    if (randomQuestion.ImagePath == "null")
                    {
                        randomQuestion.ImagePath = "/QuizImages/Elmo.gif";
                    }
                    return randomQuestion;
                }
                else if (usedQuestion.Count() == listOfAllQuestions.Count())
                {
                    usedQuestion.Clear();
                }

            }

            throw new NotImplementedException(" A random question needs to be returned here! ");
        }
    }
}
