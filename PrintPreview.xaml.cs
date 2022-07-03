using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF___Projekt.models;

namespace WPF___Projekt
{
    /// <summary>
    /// Logika interakcji dla klasy PrintPreview.xaml
    /// </summary>
    public partial class PrintPreview : Window
    {
        public Collection<Client> clientsFromMainWindow { get; } = new ObservableCollection<Client>();
        public Collection<Order> ordersFromMainWindow { get; } = new ObservableCollection<Order>();
        public Collection<Courier> couriersFromMainWindow { get; } = new ObservableCollection<Courier>();
        public PrintPreview(string type)
        {
            InitializeComponent();
            if (type == "print_clients")
            {
                //nagłówek
                clientsFromMainWindow = MainWindow.AllOfClients;
                Client nagłówek = new Client("Imię i nazwisko", "Email", "Miasto", "Adres");

                //lista klientów
                previewList.Items.Add(nagłówek.PrintString());
                foreach (var person in clientsFromMainWindow)
                {
                    string OsobaDoWydruku = person.PrintString();
                    previewList.Items.Add(OsobaDoWydruku);
                }
            }
            else if (type == "print_couriers")
            {
                //nagłówek
                couriersFromMainWindow = MainWindow.AllOfCouriers.couriers;
                Courier nagłówek = new Courier("Imię i nazwisko");

                //lista kurierów
                previewList.Items.Add(nagłówek.PrintString());
                foreach (var courier in couriersFromMainWindow)
                {
                    previewList.Items.Add(courier.PrintString());
                }
            }
            else if (type == "print_orders")
            {
                //nagłówek
                ordersFromMainWindow = MainWindow.AllOfOrders;
                Order nagłówek = new Order("Nazwa Zamówienia", "ID Kuriera", "ID Klienta", "Wpłata");

                //lista zamówień
                previewList.Items.Add(nagłówek.PrintString());
                foreach (var order in ordersFromMainWindow)
                {
                    previewList.Items.Add(order.PrintString());
                }
            }


        }
        private void PrintClick(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintVisual(previewList, "Lista do wydrukowania");
            }
        }
    }
}
