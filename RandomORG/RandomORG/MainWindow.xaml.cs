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

            if (mintext.Text.Length > maxtext.Text.Length)
                {
                    MessageBox.Show("Напишите число по меньше");
                }
        }
        private void mintext_KeyPress(object sender, KeyPressEventArgs e)
            {
            if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
