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
    /// Interaction logic for NewOrder.xaml
    /// </summary>
    public partial class NewOrder : Window
    {
        public NewOrder()
        {
            InitializeComponent();
            btnSummary.IsEnabled = true;
            btnOk.IsEnabled = true;
            btnCancel.IsEnabled = true;
            scrollbarPayment.Minimum = 1;
            scrollbarPayment.Maximum = 10000;
            txtCourierID.ItemsSource = MainWindow.AllOfCouriers.couriers;
            txtClientID.ItemsSource = MainWindow.AllOfClients;
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
            MessageBox.Show("Zamówienie zostało dodane!");
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
