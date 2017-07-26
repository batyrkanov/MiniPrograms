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

namespace MiniPrograms
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count = 0;
        int from = 0;
        int to = 0;
        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            count++;
            lblCount.Content = count.ToString();
        }

        private void btn_reset_Click(object sender, RoutedEventArgs e)
        {
            count = 0;
            lblCount.Content = count.ToString();
        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            count--;
            lblCount.Content = count.ToString();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            
            int n;
            n = rnd.Next(Convert.ToInt32(lblFirstNum.Content), Convert.ToInt32(lblSecondNum.Content));
            lblRandom.Content = n.ToString();
            if (checkBox.IsChecked == true)
            {
                int i = 0;
                while (txtbRandom.Text.IndexOf(n.ToString()) != -1)
                { 
                    n = rnd.Next(Convert.ToInt32(lblFirstNum.Content), Convert.ToInt32(lblSecondNum.Content));
                    i++;
                    if (i > 1000) break;
                }
                if (i<=1000) txtbRandom.AppendText(n + "\n");
            }
            else
            {
                txtbRandom.AppendText(n + "\n");
            }
            
        }

        private void btn1Minus_Click(object sender, RoutedEventArgs e)
        {
            from--;
            lblFirstNum.Content = from.ToString();
        }

        private void btn1Plus_Click(object sender, RoutedEventArgs e)
        {
            from++;
            lblFirstNum.Content = from.ToString();
        }

        private void btn1Minus1_Click(object sender, RoutedEventArgs e)
        {
            to--;
            lblSecondNum.Content = to.ToString();
        }

        private void btn2Plus_Click(object sender, RoutedEventArgs e)
        {
            to++;
            lblSecondNum.Content = to.ToString();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtbRandom.Clear();
        }

        private void btnRandCopy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(txtbRandom.Text);
        }
    }
}
