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

        private void digitbutton_Click(object sender, RoutedEventArgs e)
        {
            Program window = new Program();
            this.Close();
            window.ShowDialog();
        }

        private void flipbutton_Click(object sender, RoutedEventArgs e)
        {
            CoinFlip window = new CoinFlip();
            this.Close();
            window.ShowDialog();
        }
    }

}

