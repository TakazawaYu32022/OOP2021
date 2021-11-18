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
        
        Random rand = new Random();
        int randomNumber;
        //private const int Rows = 5;
        //private const int Columns = 5;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        //ロード時に一度だけ実行される
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            randomNumber = rand.Next(1, 26);

            //行
            /*for(int i = 0;i < Rows;i++){
              grid.RowDefinitions.Add(new RowDefinition());
              }
            //列
              for(int i = 0;i < Columns;i++){
              grid.ColumnDefinitions.Add(new ColumnDefinition());
              }
              for(int i = 0; i< Rows;i+;){
                    for(int j = 0;j < Columns;j++){
                      var bt = new Button();
                      bt.Width = MainForm.Width / Columns;
                      bt.Height = MainForm.Height / Rows;
                      bt.Content = (j + 1) + i * Rows;
                      bt.Click += Bt_Click;
                      Grid.SetRow(bt,i);
                      Grid.SetColumn(bt,j);
                      buttons.Add(bt);
                    }
              }
              buttons.ForEach(bt => grid.Children.Add(bt));
              MainForm.Height += tectDisp.Height + 50;*/
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            Button selectedButton = (Button)sender;
            int answer = int.Parse(selectedButton.Content.ToString());
            if(answer == randomNumber)
            {
                result.Text = "あたり";
            }else if(answer > randomNumber)
            {
                result.Text = "大きすぎ";
            }else if(answer < randomNumber)
            {
                result.Text = "小さすぎ";
            }
        }
        /*private void Bt_Click(object sender,RoutedEventArgs e){
            Button selectedButton = (Button)sender;
            int num = (int)selectedButton.Content
         }*/



    }
}
