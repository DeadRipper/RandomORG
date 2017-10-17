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
    /// Логика взаимодействия для DecWindow.xaml
    /// </summary>
    public partial class DecWindow : Window
    {
        public DecWindow()
        {
            InitializeComponent();
        }
        
        private void generdec_Button_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            resdec.Text = (r.NextDouble()*(Convert.ToDouble(maxdec.Text) - (Convert.ToDouble(mindec.Text)))+ Convert.ToDouble(mindec.Text)).ToString();
        }

        private void celdec_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.ShowDialog();
        }
    }
}
