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

namespace RandomORG
{
    /// <summary>
    /// Логика взаимодействия для CoinFlip.xaml
    /// </summary>
    public partial class CoinFlip : Window
    {
        public CoinFlip()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            this.Close();
            window.ShowDialog();
        }

        private void flipbutton_Click(object sender, EventArgs e)
        {
            int a;
            Random rand = new Random();
            a = rand.Next(Convert.ToInt32(2) - Convert.ToInt32(0));
            if (a==0)
                {
                    fliptext.Text = "Head";
                }
            else
                { 
                    fliptext.Text = "Tail";
                }
            }
        }
    }
