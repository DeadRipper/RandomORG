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
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Program : Window
    {
        public Program()
        {
            InitializeComponent();
        }

        private void generatebuton_Click(object sender, RoutedEventArgs e)
        {
            int i;
            double b;
            bool IsInt = int.TryParse(minimum.Text, out i);
            bool isDouble = Double.TryParse(minimum.Text, out b);
            Random r = new Random();
            if (IsInt)
            {
                restext.Text = (r.Next(Convert.ToInt32(maxtext.Text) - (Convert.ToInt32(minimum.Text)) + 1) + Convert.ToInt32(minimum.Text)).ToString();
            }
            else if(isDouble)
            {
                restext.Text = (r.NextDouble() * (Convert.ToDouble(maxtext.Text) - (Convert.ToDouble(minimum.Text))) + Convert.ToDouble(minimum.Text)).ToString();

            }
        }

        private void backbutton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            this.Close();
            window.ShowDialog();
        }

        private void minimum_TextChanged(object sender, TextChangedEventArgs e)
        {
            int valueInt;
            double valueDob;
            if (!int.TryParse(minimum.Text, out valueInt))
                if(!double.TryParse(minimum.Text, out valueDob))
                {
                    MessageBox.Show("Введено недопустимое значение");
                    minimum.Text = minimum.Text.Substring(0, minimum.Text.Length - 1);
                }
        }

        private void maxtext_TextChanged(object sender, TextChangedEventArgs e)
        {
            int valueInt;
            double valueDob;
            if (!int.TryParse(maxtext.Text, out valueInt))
                if (!double.TryParse(maxtext.Text, out valueDob))
                {
                    MessageBox.Show("Введено недопустимое значение");
                    maxtext.Text = maxtext.Text.Substring(0, maxtext.Text.Length - 1);
                }
        }

        private void restext_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    
}
