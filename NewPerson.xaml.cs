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

namespace WPF___Projekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class NewPerson : Window
    {

        public NewPerson()
        {
            InitializeComponent();
            btnSummary.IsEnabled = true;
            btnOk.IsEnabled = true;
            btnCancel.IsEnabled = true;
            scrollbarPayment.Minimum = 1;
            scrollbarPayment.Maximum = 10000;
        }

        //POBOCZNA FUNKCJONALNOŚĆ
        private void txtNameSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void scrollbarPayment_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtPayment.Text = ((int)scrollbarPayment.Value).ToString();
        }

        private void btnOkay_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Osoba została dodana!");
            DialogResult = true;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Odrzucono osobę.");
            DialogResult = false;
        }
        private void btnSummary_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zweryfikowano.");
        }
        //POBOCZNA FUNKCJONALNOŚĆ

    }
}
