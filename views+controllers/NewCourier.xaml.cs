using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF___Projekt.views_controllers
{
    /// <summary>
    /// Interaction logic for NewCourier.xaml
    /// </summary>
    public partial class NewCourier : Window
    {

        public NewCourier()
        {
            InitializeComponent();
            btnSummary.IsEnabled = true;
            btnOk.IsEnabled = true;
            btnCancel.IsEnabled = true;
        }

        //POBOCZNA FUNKCJONALNOŚĆ
        private void txtNameSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void btnOkay_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Kurier został dodany!");
            DialogResult = true;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Odrzucono.");
            DialogResult = false;
        }
        private void btnSummary_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zweryfikowano.");
        }
        //POBOCZNA FUNKCJONALNOŚĆ
    }
}
