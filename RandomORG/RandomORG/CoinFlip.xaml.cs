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
        private static Random rand = new Random();
        public static string RandomString(int lenght)
        {
            const string chars = "Head, Tail";
            return new string(Enumerable.Repeat(chars, lenght).Select(s => s[rand.Next(s.Length)]).ToArray());
        }


        private void fliptext_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void flipbutton_Click(object sender, EventArgs e)
        {
            WriteTextBox(Controls["fliptext"], "Head");
        }

        public void WriteTextBox(Control tb, string text)
        {
            if (tb is TextBox)
                tb.Text = text;
            else
                MessageBox.Show("Hrn'");
        }
    }
}
