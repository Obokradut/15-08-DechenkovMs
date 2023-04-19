using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace _15_08
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtFio_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Valid.IsFioValid(txtFio.Text))
                txtFio.Background = Brushes.Green;
            else
                txtFio.Background = Brushes.Red;
        }

        private void txtAddress_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Valid.IsAddressValid(txtAddress.Text))
                txtAddress.Background = Brushes.Green;
            else
                txtAddress.Background = Brushes.Red;
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Valid.IsEmailValid(txtEmail.Text))
                txtEmail.Background = Brushes.Green;
            else
                txtEmail.Background = Brushes.Red;
        }

    }
}
