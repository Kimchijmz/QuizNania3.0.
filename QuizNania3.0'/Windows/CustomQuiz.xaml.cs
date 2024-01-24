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
    /// Interaction logic for CustomQuiz.xaml
    /// </summary>
    public partial class CustomQuiz : Window
    {

        Question costumQuestion = new Question();
        private int question; 
        public CustomQuiz()
        {
            InitializeComponent();
        }


        private void SaveQuiz_Click(object sender, RoutedEventArgs e)
        {
            Quiz newCostumQuiz = new Quiz();
            
            
        }

        private void BackToMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow backToMenu = new MainWindow();
            backToMenu.Show();
            this.Close();
            

        }

        private void SaveQuestion_Click(object sender, RoutedEventArgs e)
        {
    

        }
    }
}
