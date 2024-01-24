using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizNania3._0_.Models
{
    internal class Question
    {
        public string QuestionText { get; set; }
        public string[] Answer { get; set; }
        public int CorrectAnswer { get; set; }
        public string Category { get; set; }
        public string? ImagePath { get; set; }
        public int QuestionID { get; set; }

        public Question() { }

        public Question(string questionText, string[] answer, int correctAnswer, string category, string imagePath, int questionID)
        {
            QuestionText = questionText;
            Answer = answer;
            CorrectAnswer = correctAnswer;
            Category = category;
            ImagePath = imagePath;
            QuestionID = questionID;

        }
    }
}
