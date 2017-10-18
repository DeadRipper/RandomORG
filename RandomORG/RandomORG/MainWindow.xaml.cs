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
            Random r = new Random();
            restext.Text = (r.Next(Convert.ToInt32(maxtext.Text) - (Convert.ToInt32(minimum.Text)) + 1) + Convert.ToInt32(minimum.Text)).ToString();
            if (minimum.Text.Equals(maxtext.Text))
            {
                MessageBox.Show("Vvedite chislo menshe max");
            }
        }

        private void mintext_TextChanged(object sender, TextCompositionEventArgs e)
        {
            /*try
            {
                Convert.ToInt32(minimum.Text);
                MessageBox.Show("Vvedite chislo");
            }
            catch (FormatException)
            {
                MessageBox.Show("Vvedenno ne chislo");
            }
            minimum.Clear();*/
        }

        private void newbutton_Click(object sender, RoutedEventArgs e)
        {
            maxtext.Clear();
            minimum.Clear();
            restext.Clear();
        }

        private void generdec_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            resdec.Text = (r.NextDouble() * (Convert.ToDouble(maxdec.Text) - (Convert.ToDouble(mindec.Text))) + Convert.ToDouble(mindec.Text)).ToString();
        }

        private void decbutton_Click(object sender, RoutedEventArgs e)
        {

        }

    }

}

