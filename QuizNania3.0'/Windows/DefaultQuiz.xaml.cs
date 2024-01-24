using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using QuizNania3._0_.Models;

namespace QuizNania3._0_.Windows
{
    /// <summary>
    /// Interaction logic for DefaultQuiz.xaml
    /// </summary>
    public partial class DefaultQuiz : Window
    {
        Question currentQuiz;
        Quiz quizClass = new Quiz();
        List<Question> questionList = new List<Question>();

        List<int> questionNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public DefaultQuiz(List<string> allCategories)
        {
            List<Question> allQuestions = quizClass.Questions.ToList();

            foreach (string category in allCategories)
            {
                foreach (Question questions in allQuestions)
                {
                    if (questions.Category == category)
                    {
                        questionList.Add(questions);
                    }
                }

            }

            questionList = quizClass.Questions.ToList();
            InitializeComponent();
            StartGame();
            NextQuestion();
        }

        int qNum = 0;
        int defaultQuestions;
        int score;

        private void CheckAnswer(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;

            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }

            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                qNum++;
            }
            ScoreTracker.Content = "Answered Correctly " + score + "/" + questionNumbers.Count;

            if (score == 10)
            {
                MessageBox.Show("!!!! Congrats you scored 10/10 !!!!");
                Close();
            }

            NextQuestion();
        }

        private void ReStartGame()
        {
            score = 0;
            qNum = -1;
            defaultQuestions = 0;
            StartGame();
        }
        private void NextQuestion()
        {
            currentQuiz = quizClass.GetRandomQuestion(questionList);
            Question.Text = currentQuiz.QuestionText;
            Answer1.Content = currentQuiz.Answer[0];
            Answer2.Content = currentQuiz.Answer[1];
            Answer3.Content = currentQuiz.Answer[2];

        }

        private void StartGame()
        {
            var RandomQuestion = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();
            questionNumbers = RandomQuestion;

        }

        private void BackToMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow backToMenu = new MainWindow();
            backToMenu.Show();
            this.Close();
        }
    }
}
