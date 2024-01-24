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
    /// Interaction logic for CarsWindow.xaml
    /// </summary>
    public partial class CarsWindow : Window
    {
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int qNum = 0;
        int i;
        int score;
        public CarsWindow()
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
            i = 0;
            StartGame();

        }

        private void NextQuestion()
        {

            if (qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
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

            switch (i)
            {
                case 1:
                    QuestionText.Text = "What does 'SUV' stand for?";
                    answr1.Content = "Super Urban Vechile";
                    answr2.Content = "Sport Utility Vechicle";
                    answr3.Content = "Sport Urban Vechicle";

                    answr2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/Cars.jpg"));
                    break;
                case 2:
                    QuestionText.Text = "What luxury automaker is known for its iconic \"Spirit of Ecstasy\" hood ornament?";
                    answr1.Content = "Mercedes-Benz";
                    answr2.Content = "BMW";
                    answr3.Content = "Rolls-Royce";

                    answr3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/RR.jpg"));
                    break;
                case 3:
                    QuestionText.Text = "Which luxury car brand is renowned for its \"Quattro\" all-wheel drive system?";
                    answr1.Content = "Jaguar";
                    answr2.Content = "lexus";
                    answr3.Content = "Audi";

                    answr3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/RS7.jpg"));
                    break;
                case 4:
                    QuestionText.Text = "What does the acronym \"AMG\" stand for in Mercedes-AMG vehicles?";
                    answr1.Content = "Advanced Motorsport Group";
                    answr2.Content = "Alluring Mercedes Grand";
                    answr3.Content = "Aufrecht, Melcher, and Großaspach";

                    answr3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/AMG.jpg"));
                    break;
                case 5:
                    QuestionText.Text = "Which luxury automaker produces the \"Phantom\" and \"Cullinan\" models";
                    answr1.Content = "Rolls-Royce";
                    answr2.Content = "Maserati";
                    answr3.Content = "Bentley";

                    answr1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/RR.jpg"));
                    break;
                case 6:
                    QuestionText.Text = "The \"Lamborghini Aventador\" is known for its powerful V12 engine. How much horsepower ";
                    answr1.Content = "500";
                    answr2.Content = "700";
                    answr3.Content = "1000";

                    answr2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/Lambo.jpg"));
                    break;
                case 7:
                    QuestionText.Text = "Which high-end automobile brand is famous for its \"Porsche 911\" model?";
                    answr1.Content = "Bugatti";
                    answr2.Content = "Porsche";
                    answr3.Content = "Aston Martin";

                    answr2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/Porsche.jpg"));
                    break;
                case 8:
                    QuestionText.Text = "Which luxury automaker is associated with the slogan \"The Best or Nothing\"?";
                    answr1.Content = "Mercedes-Benz";
                    answr2.Content = "Jaguar";
                    answr3.Content = "Audi";

                    answr1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/AMG.jpg"));
                    break;
                case 9:
                    QuestionText.Text = "The \"Lexus RX\" is a popular luxury SUV. What does \"RX\" stand for?";
                    answr1.Content = "Reliable Crossover";
                    answr2.Content = "Radical Experience";
                    answr3.Content = "Radiant Luxury";

                    answr3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/cars.jpg"));
                    break;
                case 10:
                    QuestionText.Text = "Which Italian luxury car manufacturer is famous for its \"LaFerrari\" hypercar";
                    answr1.Content = "Lamborghini";
                    answr2.Content = "Ferrari";
                    answr3.Content = "Alfa Romeo";

                    answr2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/Ferrari.jpg"));
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
