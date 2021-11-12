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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGame
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        int answer = 0;
        Random rand = new Random();
        int randomNumber = rand.Next(1, 25);

        private void Number1_Click(object sender, RoutedEventArgs e)
        {
            answer = 1;
            if(answer == randomNumber)
            {
                MessageBox.Show("あたり");
            }else if(answer > randomNumber)
            {

            }
        }

        private void Number2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Number3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Number4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Number5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Number6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Number7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Number8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Number9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Number10_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Number11_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Number12_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Number13_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Number14_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Number15_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Number16_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Number17_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Number18_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Number19_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Number20_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Number21_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Number22_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Number23_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Number24_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Number25_Click(object sender, RoutedEventArgs e)
        {

        }
        

        
    }
}
