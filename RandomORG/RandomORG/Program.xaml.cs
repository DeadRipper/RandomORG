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
            int parsedValue;
            double parsedValueDob;
            if (!int.TryParse(minimum.Text, out parsedValue))
                if (!double.TryParse(minimum.Text, out parsedValueDob))
                {
                    minimum.Clear();
                }
                else
                {
                    return;
                }
            return;
        }
    }
}
