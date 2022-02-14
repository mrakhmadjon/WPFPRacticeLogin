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

namespace WPFPRacticeLogin
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
            string email = emailBoxUI.Text;
            string password = passwordBoxUI.Password;

            if (string.IsNullOrEmpty(email))
                MessageBox.Show("Enter Email");
            else if (string.IsNullOrEmpty(password))
                MessageBox.Show("Enter Password");
            else
            { MessageBox.Show("Saved Successfully"); 
                emailBoxUI.Clear();
                passwordBoxUI.Clear();
            }
             
        }
    }
}
