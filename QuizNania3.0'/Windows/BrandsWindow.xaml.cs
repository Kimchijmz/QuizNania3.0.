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
    /// Interaction logic for BrandsWindow.xaml
    /// </summary>
    public partial class BrandsWindow : Window
    {
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int qNum = 0;
        int BrandsQuestion;
        int score;
        public BrandsWindow()
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
            BrandsQuestion = 0;
            StartGame();

        }

        private void NextQuestion()
        {

            if (qNum < questionNumbers.Count)
            {
                BrandsQuestion = questionNumbers[qNum];
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

            switch (BrandsQuestion)
            {
                case 1:
                    QuestionText.Text = "Which luxury brand is famous for its iconic monogram pattern and brown leather goods?";
                    answr1.Content = "Fendi";
                    answr2.Content = "Louis Vuitton";
                    answr3.Content = "Gucci";

                    answr2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/LV.png"));
                    break;
                case 2:
                    QuestionText.Text = "The \"FF\" logo is closely associated with which high-end fashion brand??";
                    answr1.Content = "Fenty";
                    answr2.Content = "Ferragamo";
                    answr3.Content = "Fendi";

                    answr3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/Fendi.png"));
                    break;
                case 3:
                    QuestionText.Text = "Which luxury fashion house is known for its double \"G\" logo and green-and-red striped webbing?";
                    answr1.Content = "Dolce Gabanna";
                    answr2.Content = "Givenchy";
                    answr3.Content = "Gucci";

                    answr3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/Gucci.jpg"));
                    break;
                case 4:
                    QuestionText.Text = "Who is the creative director behind Louis Vuitton's men's collections and is famous for his streetwear influence?";
                    answr1.Content = "Karl Lagerfeld";
                    answr2.Content = "Donatella Versace";
                    answr3.Content = "Virgil Abloh";

                    answr3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/LV.png"));
                    break;
                case 5:
                    QuestionText.Text = "Philipp Plein is a luxury brand known for its edgy and extravagant designs. Where is the designer Philipp Plein originally from?";
                    answr1.Content = "Germany";
                    answr2.Content = "Italy";
                    answr3.Content = "France";

                    answr1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/PP.jpg"));
                    break;
                case 6:
                    QuestionText.Text = "Which luxury brand is recognized for its Medusa head logo and bold, colorful designs?";
                    answr1.Content = "Yves Saint Laurent";
                    answr2.Content = "Versace";
                    answr3.Content = "Prada";

                    answr2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/Versace.png"));
                    break;
                case 7:
                    QuestionText.Text = "Gucci was founded in which Italian city?";
                    answr1.Content = "Milan";
                    answr2.Content = "Florence";
                    answr3.Content = "Rome";

                    answr2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/Gucci.jpg"));
                    break;
                case 8:
                    QuestionText.Text = "Which luxury brand is known for its signature studded and embellished designs, often associated with a rock 'n' roll aesthetic?";
                    answr1.Content = "Phhilipp Plein";
                    answr2.Content = "Balenciaga";
                    answr3.Content = "Y3";

                    answr1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/PP.jpg"));
                    break;
                case 9:
                    QuestionText.Text = "Louis Vuitton is a subsidiary of which multinational luxury goods conglomerate?";
                    answr1.Content = "Kering";
                    answr2.Content = "Richemont";
                    answr3.Content = "LVMH Moët Hennessy Louis Vuitton";

                    answr3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/LV.png"));
                    break;
                case 10:
                    QuestionText.Text = "What is Donatella Versace have for title at the fashion house?";
                    answr1.Content = "Chief Executive Officer (CEO)";
                    answr2.Content = "Creative Director";
                    answr3.Content = "Chief Artistic Officer (CAO)";

                    answr2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/QuizImages/Versace.png"));
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
