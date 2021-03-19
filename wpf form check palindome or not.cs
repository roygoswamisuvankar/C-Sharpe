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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n, y = 0, i, tmp;
            if (System.Text.RegularExpressions.Regex.IsMatch(text1.Text, "^[0-9]"))
            {
                n = int.Parse(text1.Text);

                tmp = n;
                while (n != 0)
                {
                    i = n % 10;
                    y = y * 10 + i;
                    n = n / 10;
                }
                if (y == tmp)
                {
                    MessageBox.Show("This is a Palindrome Number");
                }
                else
                {
                    MessageBox.Show("This is not a Palindome Number");
                }
            }
            else
            {
                MessageBox.Show("Please enter Numberic Values only");
            }
        }
    }
}
