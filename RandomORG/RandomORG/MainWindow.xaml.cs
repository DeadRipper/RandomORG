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


namespace RandomORG
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void generatebuton_Click(object sender, RoutedEventArgs e)
        {

            /*if (mintext.Text.Length > mintext.Text.Length)
                {
                    MessageBox.Show("Напишите число по меньше");
                }*/
            Random r = new Random();
            restext.Text = (r.Next(Convert.ToInt32(maxtext.Text) - (Convert.ToInt32(minimum.Text))+1)+Convert.ToInt32(minimum.Text)).ToString();
        }

        private void mintext_TextChanged(object sender, TextCompositionEventArgs e)
        {
            try
            {
                Convert.ToInt32(minimum.Text);
                MessageBox.Show("Vvedite chislo");
            }
            catch (FormatException)
            {
                MessageBox.Show("Vvedenno ne chislo");
            }
            minimum.Clear();
        }

        private void decbutton_Click_1(object sender, RoutedEventArgs e)
        {
            DecWindow a = new DecWindow();
            a.ShowDialog();
        }

        private void newbutton_Click(object sender, RoutedEventArgs e)
        {
            maxtext.Clear();
            minimum.Clear();
            restext.Clear();
        }
    }
}
