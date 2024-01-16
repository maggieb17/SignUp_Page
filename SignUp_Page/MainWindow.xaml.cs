using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

namespace SignUp_Page
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
            char[] arr = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '+', '=', '{', '}', '[', ']', '|', '\\', ';', ':', '\'', '"', '<', '>', ',', '.', '/', '?' };
            string ran = arr.ToString();
            char email = '@';

            if(txtName.Text == "" || txtLname.Text == "")
            {
                MessageBox.Show("First Name and Last Name should be entered!");
            }
            else if (txtPassword.Password.Length<8 && !txtPassword.Password.Contains(ran))
            {
                MessageBox.Show("Password should be longer or it does not contain a special character. Go back and try again");
            }
            else if (!txtEmail.Text.Contains(email))
            {
                MessageBox.Show("Email does not exist. Go back and try again");
            }
            else if (txtPassword.Password != txtPassword2.Password)
            {
                MessageBox.Show("Passwords do not match. Go back and try again");
            }
            else
            {
                MessageBox.Show($"Your username is: {txtUsername.Text}, and your password is: {txtPassword.Password}");
            }
        }


        private void UsernameClear(object sender, RoutedEventArgs e)
        {
            txtUsername.Text = "";
        }

        private void FirstNameClear(object sender, RoutedEventArgs e)
        {
            txtName.Text = "";
        }

        private void LNameClear(object sender, RoutedEventArgs e)
        {
            txtLname.Text = "";
        }

        private void EmailClear(object sender, RoutedEventArgs e)
        {
            txtEmail.Text = "";
        }
    }
}
