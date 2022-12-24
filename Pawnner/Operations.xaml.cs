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

namespace Pawnner
{
    /// <summary>
    /// Interaction logic for Operations.xaml
    /// </summary>
    public partial class Operations : Window
    {
        public Operations()
        {
            InitializeComponent();
            OperationFrame.Content = new Home();
        }

        private void Home(object sender, MouseButtonEventArgs e )
        {
            OperationFrame.Content = new Home();
        }
        private void AddCustomer(object sender, MouseButtonEventArgs e)
        {
            OperationFrame.Content = new AddCustomer();
        }

        private void customerHistory(object sender, MouseButtonEventArgs e)
        {
            OperationFrame.Content = new CustomerHistory();
        }

        private void addItem(object sender, MouseButtonEventArgs e)
        {
            OperationFrame.Content = new AddItem();
        }

        private void printBill(object sender, MouseButtonEventArgs e)
        {
            OperationFrame.Content = new PrintBill();
        }

        private void logout(object sender, MouseButtonEventArgs e)
        {
            MainWindow login = new MainWindow();
            login.Show();
            this.Close();
        }
    }
}
