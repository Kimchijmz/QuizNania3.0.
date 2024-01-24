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
    /// Interaction logic for ChooseCategory.xaml
    /// </summary>
    public partial class ChooseCategory : Window
    {
        public ChooseCategory()
        {
            InitializeComponent();
        }

        private void CarsCategory_Click(object sender, RoutedEventArgs e)
        {
            CarsWindow CarQuiz = new CarsWindow();
            CarQuiz.Show();
            this.Close();
        }

        private void SportsCategory_Click(object sender, RoutedEventArgs e)
        {
            SportsWindow SportQuiz = new SportsWindow();
            SportQuiz.Show();
            this.Close();
        }

        private void BrandsCategory_Click(object sender, RoutedEventArgs e)
        {
            BrandsWindow BrandsQuiz = new BrandsWindow();
            BrandsQuiz.Show();
            this.Close();
        }

        private void HipHopCategory_Click(object sender, RoutedEventArgs e)
        {
            HipHopWindow HipHopQuiz = new HipHopWindow();
            HipHopQuiz.Show();
            this.Close();

        }

        private void BackToMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow backToMenu = new MainWindow();
            backToMenu.Show();
            this.Close();
        }
    }
}
