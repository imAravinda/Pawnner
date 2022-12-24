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

namespace Pawnner
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void FrogotPasswordClick(object sender, MouseButtonEventArgs e)
        {
            PasswordReset passwordReset = new PasswordReset();
            passwordReset.Show();
            this.Close();
        }

        private void SignUp(object sender, MouseButtonEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(userID.Text == "SC11130" && Password.Text == "1234")
            {
                Operations op = new Operations();
                op.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Cridentials");
            }
        }
    }
}
