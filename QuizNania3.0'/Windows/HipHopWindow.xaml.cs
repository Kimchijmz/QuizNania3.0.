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
    /// Interaction logic for HipHopWindow.xaml
    /// </summary>
    public partial class HipHopWindow : Window
    {
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int qNum = 0;
        int hiphopQuestions;
        int score;
        public HipHopWindow()
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
            hiphopQuestions = 0;
            StartGame();

        }

        private void NextQuestion()
        {

            if (qNum < questionNumbers.Count)
            {
                hiphopQuestions = questionNumbers[qNum];
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

            switch (hiphopQuestions)
            {
                case 1:
                    QuestionText.Text = "Which legendary hip-hop artist is known for his prominent figure in the West Coast hip-hop scene?";
                    answr1.Content = "Snoop Dog";
                    answr2.Content = "Tupac Shakur";
                    answr3.Content = "Dr.Dre";

                    answr2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/2pac.jpg"));
                    break;
                case 2:
                    QuestionText.Text = "What hip-hop group from Compton, California, released the album \"Straight Outta Compton\" in 1988?";
                    answr1.Content = "Run-DMC";
                    answr2.Content = "Public Enemy";
                    answr3.Content = "N.W.A";

                    answr3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/NWA.jpg"));
                    break;
                case 3:
                    QuestionText.Text = "What pioneering hip-hop group from Compton, California, released the influential album \"Straight Outta Compton\" in 1988?";
                    answr1.Content = "1991";
                    answr2.Content = "1997";
                    answr3.Content = "1993";

                    answr3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/Wutang.jpg"));
                    break;
                case 4:
                    QuestionText.Text = "Who is often credited with being the \"Godfather of Hip-Hop\"?";
                    answr1.Content = "Kanye West";
                    answr2.Content = "Jay-z";
                    answr3.Content = "Grandmaster Flash";

                    answr3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/HipHop.jpg"));
                    break;
                case 5:
                    QuestionText.Text = "The five elements of hip-hop culture include MCing, DJing, graffiti, breakdancing, and what other element?";
                    answr1.Content = "Beatboxing";
                    answr2.Content = "StreetArt";
                    answr3.Content = "Fashion";

                    answr1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/HipHop.jpg"));
                    break;
                case 6:
                    QuestionText.Text = "\"It Was Written\" and \"Illmatic\" are classic albums by which influential rapper from New York?";
                    answr1.Content = "Jay-z";
                    answr2.Content = "Nas";
                    answr3.Content = "B.I.G";

                    answr2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/HipHop.jpg"));
                    break;
                case 7:
                    QuestionText.Text = "What is the term for the vocal style in hip-hop where artists use rapid and rhythmic speech with a focus on wordplay and lyrical dexterity?";
                    answr1.Content = "Rhyme scheme";
                    answr2.Content = "Flow";
                    answr3.Content = "Ad-lib    ";

                    answr2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/HipHop.jpg"));
                    break;
                case 8:
                    QuestionText.Text = "Who is the member of Wu-Tang Clan known for his distinctive storytelling style?";
                    answr1.Content = "Raekwon";
                    answr2.Content = "Method Man";
                    answr3.Content = "RZA";

                    answr1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/Wutang.jpg"));
                    break;
                case 9:
                    QuestionText.Text = "In which U.S. city did hip-hop originate in the 1970s, leading to the birth of the genre?";
                    answr1.Content = "Los Angeles";
                    answr2.Content = "Chicago";
                    answr3.Content = "New York City";

                    answr3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/HipHop.jpg"));
                    break;
                case 10:
                    QuestionText.Text = "Who have won 21 Grammys in the HipHop category?";
                    answr1.Content = "Kanyne West";
                    answr2.Content = "Jay-Z";
                    answr3.Content = "Drake";

                    answr2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/HipHop.jpg"));
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
