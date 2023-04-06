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


namespace ManagingAPP
{
    /// <summary>
    /// Logique d'interaction pour Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text; 
            if(username =="Test" && password == "Test")
            {
                this.Visibility = Visibility.Hidden;

                MainWindow wind = new();
                wind.ShowDialog();

            }

        }

        private void textBoxUsername_StylusEnter(object sender, StylusEventArgs e)
        {
            if(textBoxUsername.Text == "Nom d'utilisateur ")
            {
                textBoxUsername.Text = "";
            }
        }

        private void textBoxUsername_StylusLeave(object sender, StylusEventArgs e)
        {
            if(textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Nom d'utilisateur";
            }
        }

        private void textBoxUsername_MouseEnter(object sender, MouseEventArgs e)
        {
            

        }

        private void textBoxUsername_MouseLeave(object sender, MouseEventArgs e)
        {
           
        }

        private void textBoxUsername_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Nom d'utilisateur";
            }
        }
    }
}
