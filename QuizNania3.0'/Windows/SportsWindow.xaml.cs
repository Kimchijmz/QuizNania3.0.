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

namespace QuizNania3._0_.Windows
{
    /// <summary>
    /// Interaction logic for SportsWindow.xaml
    /// </summary>
    public partial class SportsWindow : Window
    {
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int qNum = 0;
        int sportsQuestions;
        int score;
        public SportsWindow()
        {
            InitializeComponent();
            StartGame();
            NextQuestion();
        }

        public void checkAnswer(object sender, RoutedEventArgs e)
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
            scoreText.Content = "Answerd Correctly" + score + "/" + questionNumbers.Count;

            if (score == 10)
            {
                MessageBox.Show("!!!! Congrats you scored 10/10 !!!!");
                Close();
            }

            NextQuestion();
        }

        private void RestartGame()
        {

            score = 0;
            qNum = -1;
            sportsQuestions = 0;
            StartGame();

        }

        private void NextQuestion()
        {

            if (qNum < questionNumbers.Count)
            {
                sportsQuestions = questionNumbers[qNum];
            }
            else
            {
                RestartGame();
            }

            foreach (var x in myGrid.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.LightGreen;

            }

            switch (sportsQuestions)
            {
                case 1:
                    QuestionText.Text = "Who is often referred to as the \"Black Mamba\" and had a legendary career with the Los Angeles Lakers in the NBA?";
                    answr1.Content = "LeBron James";
                    answr2.Content = "Michael Jordan";
                    answr3.Content = "Kobe Bryant";

                    answr3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/NBA.jpg"));
                    break;
                case 2:
                    QuestionText.Text = "In soccer, which country won the 2018 FIFA World Cup?";
                    answr1.Content = "Germany";
                    answr2.Content = "France";
                    answr3.Content = "Brazil";

                    answr2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/Soccer.jpg"));
                    break;
                case 3:
                    QuestionText.Text = "Who is the UFC fighter known for his Irish heritage and charismatic personality, often called \"The Notorious\"?";
                    answr1.Content = "Jon Jones";
                    answr2.Content = "Khabib Nurmagomedov";
                    answr3.Content = "Conor McGregor";

                    answr3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/UFC.jpg"));
                    break;
                case 4:
                    QuestionText.Text = "In MMA, what does the acronym \"UFC\" stand for?";
                    answr1.Content = "Ultimate Fight Championship";
                    answr2.Content = "Universal Fighting Championship";
                    answr3.Content = "Ultimate Fighting Championship";

                    answr2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/UFC.jpg"));
                    break;
                case 5:
                    QuestionText.Text = "Which NBA team is known as the \"Lob City\" due to their exciting style of play, featuring alley-oop dunks?";
                    answr1.Content = "Los Angeles Clippers";
                    answr2.Content = "Los Angeles Lakers";
                    answr3.Content = "Golden State Warriors";

                    answr1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/NBA.jpg"));
                    break;
                case 6:
                    QuestionText.Text = "In soccer, which prestigious club is often referred to as \"The Old Lady\" and is based in Turin, Italy?";
                    answr1.Content = "Fc Barcelona";
                    answr2.Content = "Real Madrid";
                    answr3.Content = "Juventus";

                    answr3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/Soccer.jpg"));
                    break;
                case 7:
                    QuestionText.Text = "Who holds the record for the most UFC title defenses in the history of the organization?";
                    answr1.Content = "Jon Jones";
                    answr2.Content = "Georges St-Pierre";
                    answr3.Content = "Anderson Silva";

                    answr1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/UFC.jpg"));
                    break;
                case 8:
                    QuestionText.Text = "What is the maximum number of players a soccer team can have on the field at any given time during a match?";
                    answr1.Content = "10 Players";
                    answr2.Content = "11 Players";
                    answr3.Content = "12 Players";

                    answr2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/Soccer.jpg"));
                    break;
                case 9:
                    QuestionText.Text = "In the NBA, which player is often referred to as \"The Greek Freak\" due to his extraordinary athleticism and versatility?";
                    answr1.Content = "Giannis Antetokounmpo";
                    answr2.Content = "Kevin Durant";
                    answr3.Content = "Kawhi Leonard";

                    answr1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/NBA.jpg"));
                    break;
                case 10:
                    QuestionText.Text = "What is the main objective in a mixed martial arts (MMA) fight?";
                    answr1.Content = "Score points through takedowns";
                    answr2.Content = "Submit your opponent or win by knockout";
                    answr3.Content = "Avoid getting hit by your opponent";

                    answr2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/UFC.jpg"));
                    break;


            }

        }

        private void StartGame()
        {
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();
            questionNumbers = randomList;
            questionOrder.Content = null;

            for (int i = 0; i < questionNumbers.Count; i++)
            {
                questionOrder.Content += " " + questionNumbers[i].ToString();
            }

        }

        private void BackToMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow backToMenu = new MainWindow();
            backToMenu.Show();
            this.Close();
        }
    }
}
