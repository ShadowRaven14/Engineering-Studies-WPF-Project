using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using WPF___Projekt.models;
using WPF___Projekt.views_controllers;

namespace WPF___Projekt
{
    public class AllOfCouriers 
    {
        public Collection<Courier> couriers { get; set; } = new ObservableCollection<Courier>();
    }

    public partial class MainWindow : Window
    {

        public Collection<Person> AllOfPeople { get; } = new ObservableCollection<Person>();
        public static Collection<Order> AllOfOrders { get; set; } = new ObservableCollection<Order>();
        public static AllOfCouriers AllOfCouriers { get; set; } = new AllOfCouriers();
        public static Collection<Client> AllOfClients { get; set; } = new ObservableCollection<Client>();



        //Przygotowanie okna
        public MainWindow()
        {
            InitializeComponent();
            
            //Order_txtCourierID.ItemsSource = AllOfCouriers.couriers;
            //Dostępność przycisków
            if (listOfOrders.Items.Count == 0)
            {
                EditOrderButton.IsEnabled = false;
                DeleteOrderButton.IsEnabled = false;
                ViewOrderButton.IsEnabled = false;
                PrintOrderButton.IsEnabled = false;
                MapOrderButton.IsEnabled = false;
            }

            if (listOfCouriers.Items.Count == 0)
            {
                EditCourierButton.IsEnabled = false;
                DeleteCourierButton.IsEnabled = false;
                ViewCourierButton.IsEnabled = false;
                PrintCourierButton.IsEnabled = false;
                MapCourierButton.IsEnabled = false;
            }

            if (listOfClients.Items.Count == 0)
            {
                EditClientButton.IsEnabled = false;
                DeleteClientButton.IsEnabled = false;
                ViewClientButton.IsEnabled = false;
                PrintClientButton.IsEnabled = false;
                MapClientButton.IsEnabled = false;
            }

            btnOrderSummary.IsEnabled = false;
            btnOrderOk.IsEnabled = false;
            btnOrderCancel.IsEnabled = false;
            Order_scrollbarPayment.Minimum = 1;
            Order_scrollbarPayment.Maximum = 10000;

            btnCourierSummary.IsEnabled = false;
            btnCourierOk.IsEnabled = false;
            btnCourierCancel.IsEnabled = false;

            btnClientSummary.IsEnabled = false;
            btnClientOk.IsEnabled = false;
            btnClientCancel.IsEnabled = false;

            btnSummary.IsEnabled = false;
            btnOk.IsEnabled = false;
            btnCancel.IsEnabled = false;
            scrollbarPayment.Minimum = 1;
            scrollbarPayment.Maximum = 10000;

            //Static data
            AllOfCouriers.couriers = CourierJSONDeserializer();
            AllOfClients = ClientJSONDeserializer();
            AllOfOrders = OrderJSONDeserializer();

            //AllOfCouriers.couriers.Add(new Courier("KurierPierwszy", "email1@gmail.com", "123 456 789"));
            //AllOfClients.Add(new Client("StudentPierwszy", "student1@email.com", "14.06.2022 21:37:01"));
            //AllOfClients.Add(new Client("StudentDrugi", "student2@email.com", "15.06.2022 21:37:02"));
            //AllOfClients.Add(new Client("StudentTrzeci", "student3@email.com", "16.06.2022 21:37:03"));
            //AllOfClients.Add(new Client("StudentCzwarty", "student4@email.com", "17.06.2022 21:37:04"));
            //AllOfClients.Add(new Client("StudentPiąty", "student5@email.com", "18.06.2022 21:37:05"));
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //binding w kodzie
            var binding = new Binding();
            binding.Source = new Person { };
            binding.Path = new PropertyPath("NameSurname");
            //boxToBind.SetBinding(TextBox.TextProperty, binding);

            //binding kolekcji
            listOfClients.ItemsSource = AllOfClients;
            listOfCouriers.ItemsSource = AllOfCouriers.couriers;
            listOfOrders.ItemsSource = AllOfOrders;
            
            Order_txtCourierID.ItemsSource = AllOfCouriers.couriers;
            Order_txtClientID.ItemsSource = AllOfClients;
        }






        //ZAMÓWIENIE
        //GŁÓWNA FUNKCJONALNOŚĆ ZAMÓWIENIE
        private void OrderJSONSerializer()
        {
            //serializowanie listy klientów przy dodawaniu nowego

            using (StreamWriter sw = new StreamWriter(@"orders.txt"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                sw.WriteLine(JsonConvert.SerializeObject(AllOfOrders));
                listOfOrders.Items.Refresh();
            }

        }
        private Collection<Order> OrderJSONDeserializer()
        {
            Collection<Order> orders_col = new Collection<Order>();
            using (StreamReader sr = new StreamReader(@"orders.txt"))
            {
                string r = sr.ReadLine();
                if (r != null)
                    orders_col = JsonConvert.DeserializeObject<Collection<Order>>(r);
                else { orders_col.Add(new Order()); return orders_col; }
            }
            listOfOrders.Items.Refresh();
            return orders_col;
        }

        private void AddOrderClick(object sender, RoutedEventArgs e)
        {
            string packageStatus = ""; string bonus = ""; string arriveWhen = "";

            /*
            if (add.PackageStatus
                status1
                .male.IsChecked == true) packageStatus = add.male.Content.ToString();
            if (add.female.IsChecked == true) packageStatus = add.male.Content.ToString();
            if (add.unknown.IsChecked == true) packageStatus = add.unknown.Content.ToString();
            if (add.unknown.IsChecked == true) packageStatus = add.unknown.Content.ToString();

            if (add.Oplata.IsChecked == true) type = type + add.Oplata.Content.ToString() + " ";
            if (add.Charytatywne.IsChecked == true) type = type + add.Charytatywne.Content.ToString() + " ";
            if (add.Napiwek.IsChecked == true) type = type + add.Napiwek.Content.ToString() + " ";
            if (type == "") type = "brak";

            if (add.Standard.IsChecked == true) term = add.Standard.Content.ToString();
            if (add.Ekspres.IsChecked == true) term = add.Ekspres.Content.ToString();
            */

            NewOrder add = new NewOrder();
            if (add.ShowDialog() == true)
            {
                AllOfOrders.Add(
                    new Order(
                            add.txtNameSurname.Text,
                            add.txtCourierID.Text,
                            add.txtClientID.Text,
                            add.txtPayment.Text,

                            add.cmbPackageStatus.SelectedIndex.ToString(),
                            bonus,
                            add.cmbArriveWhen.SelectedIndex.ToString(),

                            add.txtCity.Text,
                            add.txtStreet.Text,
                            add.txtCode.Text,
                            add.txtPhone.Text,

                            add.txtSummary.Text
                            ));
                listOfOrders.SelectedIndex = AllOfOrders.Count - 1;
                Order_txtNameSurname.SelectAll();
                Order_txtNameSurname.Focus();
                listOfOrders.Items.Refresh();
            }

            OrderJSONSerializer();
        }

        private void EditOrderClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Brak funkcjonalności, zadanie jest oparte na wiązaniach!");
        }

        private void DeleteOrderClick(object sender, RoutedEventArgs e)
        {
            if (listOfOrders.SelectedIndex >= 0)
            {
                if (MessageBox.Show(
                "Czy na pewno chcesz usunąć wskazane zamówienie z listy?",
                "Usuń element", MessageBoxButton.YesNo,
                MessageBoxImage.Question) != MessageBoxResult.Yes)
                    return;
                AllOfOrders.RemoveAt(listOfOrders.SelectedIndex);
                listOfOrders.Items.Refresh();
                OrderJSONSerializer();
            }

            if (listOfOrders.Items.Count == 0)
            {
                EditOrderButton.IsEnabled = false;
                DeleteOrderButton.IsEnabled = false;
                ViewOrderButton.IsEnabled = false;
                PrintOrderButton.IsEnabled = false;
                MapOrderButton.IsEnabled = false;
            }
        }

        private void ViewOrderClick(object sender, RoutedEventArgs e)
        {
            if (listOfOrders.SelectedIndex >= 0)
            {
                if (MessageBox.Show(listOfOrders.SelectedItem.ToString(),
                "Szczegóły Zamówienia", MessageBoxButton.OK,
                MessageBoxImage.Information) != MessageBoxResult.Yes)
                    return;
            }
        }

        private void OrderGotFocus(object sender, RoutedEventArgs e)
        {
            EditOrderButton.IsEnabled = true;
            DeleteOrderButton.IsEnabled = true;
            ViewOrderButton.IsEnabled = true;
            PrintOrderButton.IsEnabled = true;
            MapOrderButton.IsEnabled = true;
        }

        private void MapOrderClick(object sender, RoutedEventArgs e)
        {
            string adres = Order_txtCode.Text + " " + Order_txtCity.Text + " " + Order_txtStreet.Text;
            MapWindow map = new MapWindow(adres);
            map.Show();
        }
        //GŁÓWNA FUNKCJONALNOŚĆ ZAMÓWIENIE


        //POBOCZNA FUNKCJONALNOŚĆ ZAMÓWIENIE
        private void Order_txtNameSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Order_txtCourierID.Text != "")
            {
                btnOrderSummary.IsEnabled = true;
                btnOrderOk.IsEnabled = true;
                btnOrderCancel.IsEnabled = true;
            }
            else
            {
                btnOrderSummary.IsEnabled = false;
                btnOrderOk.IsEnabled = false;
                btnOrderCancel.IsEnabled = false;
            }
            listOfOrders.Items.Refresh();
            OrderJSONSerializer();
        }

        private void Order_scrollbarPayment_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Order_txtPayment.Text = ((int)Order_scrollbarPayment.Value).ToString();

            listOfOrders.Items.Refresh();
            //OrderJSONSerializer();
        }

        private void Order_btnOkay_Click(object sender, RoutedEventArgs e)
        {
            string packageStatus = ""; string bonus = ""; string arriveWhen = "";
            AllOfOrders.Add(
                    new Order(
                        Order_txtNameSurname.Text,
                        Order_txtCourierID.Text,
                        Order_txtClientID.Text,
                        Order_txtPayment.Text,

                        Order_cmbPackageStatus.SelectedIndex.ToString(),
                        bonus,
                        Order_cmbArriveWhen.SelectedIndex.ToString(),

                        txtCity.Text,
                        txtStreet.Text,
                        txtCode.Text,
                        txtPhone.Text,

                        txtSummary.Text
                        ));
            listOfOrders.SelectedIndex = AllOfOrders.Count - 1;
            Order_txtNameSurname.SelectAll();
            Order_txtNameSurname.Focus();
            OrderJSONSerializer();
            MessageBox.Show("Zamówienie zostało dodane!");

        }

        private void Order_btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Odrzucono.");
        }
        private void Order_btnSummary_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zweryfikowano.");
        }
        private void Order_clientChange(object sender, SelectionChangedEventArgs e)
        {
            OrderJSONSerializer();
        }
        //POBOCZNA FUNKCJONALNOŚĆ ZAMÓWIENIE
        //ZAMÓWIENIE





        //KURIER
        //GŁÓWNA FUNKCJONALNOŚĆ KURIER

        private void CourierJSONSerializer()
        {
            //serializowanie listy klientów przy dodawaniu nowego

            using (StreamWriter sw = new StreamWriter(@"couriers.txt"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                sw.WriteLine(JsonConvert.SerializeObject(AllOfCouriers.couriers));
                listOfCouriers.Items.Refresh();
            }
        }
        private Collection<Courier> CourierJSONDeserializer()
        {
            Collection<Courier> couriers_col = new Collection<Courier>();
            using (StreamReader sr = new StreamReader(@"couriers.txt"))
            {
                couriers_col = JsonConvert.DeserializeObject<Collection<Courier>>(sr.ReadLine());
            }
            listOfCouriers.Items.Refresh();
            return couriers_col;
        }

        private void AddCourierClick(object sender, RoutedEventArgs e)
        {
            NewCourier add = new NewCourier();
            if (add.ShowDialog() == true)
            {
                AllOfCouriers.couriers.Add(
                    new Courier(
                        add.txtNameSurname.Text,
                        add.txtEmail.Text,
                        add.txtPhone.Text));
                listOfCouriers.SelectedIndex = AllOfCouriers.couriers.Count - 1;
                Courier_txtNameSurname.SelectAll();
                Courier_txtNameSurname.Focus();
                listOfCouriers.Items.Refresh();
                CourierJSONSerializer(); 
            }
        }

        private void EditCourierClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Brak funkcjonalności, zadanie jest oparte na wiązaniach!");
        }

        private void DeleteCourierClick(object sender, RoutedEventArgs e)
        {
            if (listOfCouriers.SelectedIndex >= 0)
            {
                if (MessageBox.Show(
                "Czy na pewno chcesz usunąć wskazanego kuriera z listy?",
                "Usuń element", MessageBoxButton.YesNo,
                MessageBoxImage.Question) != MessageBoxResult.Yes)
                    return;
                AllOfCouriers.couriers.RemoveAt(listOfCouriers.SelectedIndex);
               
            }

            if (listOfCouriers.Items.Count == 0)
            {
                EditCourierButton.IsEnabled = false;
                DeleteCourierButton.IsEnabled = false;
                ViewCourierButton.IsEnabled = false;
                PrintCourierButton.IsEnabled = false;
                MapCourierButton.IsEnabled = false;
            }
            listOfCouriers.Items.Refresh();
            CourierJSONSerializer();
        }

        private void ViewCourierClick(object sender, RoutedEventArgs e)
        {
            if (listOfCouriers.SelectedIndex >= 0)
            {
                if (MessageBox.Show(listOfCouriers.SelectedItem.ToString(),
                "Szczegóły Kuriera", MessageBoxButton.OK,
                MessageBoxImage.Information) != MessageBoxResult.Yes)
                    return;
            }
        }
        //drukowanie
        private void PrintCourierClick(object sender, RoutedEventArgs e)
        {
            PrintPreview printPreview = new PrintPreview("print_couriers");
            printPreview.Show();
        }
        private void PrintClientClick(object sender, RoutedEventArgs e)
        {
            PrintPreview printPreview = new PrintPreview("print_clients");
            printPreview.Show();
        }
        private void PrintOrderClick(object sender, RoutedEventArgs e)
        {
            PrintPreview printPreview = new PrintPreview("print_orders");
            printPreview.Show();
        }
        private void CourierGotFocus(object sender, RoutedEventArgs e)
        {
            EditCourierButton.IsEnabled = true;
            DeleteCourierButton.IsEnabled = true;
            ViewCourierButton.IsEnabled = true;
            PrintCourierButton.IsEnabled = true;
            MapCourierButton.IsEnabled = true;

        }
        //GŁÓWNA FUNKCJONALNOŚĆ KURIER

        //POBOCZNA FUNKCJONALNOŚĆ KURIER
        private void Courier_txtData_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Courier_txtNameSurname.Text != "")
            {
                btnCourierSummary.IsEnabled = true;
                btnCourierOk.IsEnabled = true;
                btnCourierCancel.IsEnabled = true;
                
            }
            else
            {
                btnCourierSummary.IsEnabled = false;
                btnCourierOk.IsEnabled = false;
                btnCourierCancel.IsEnabled = false;
            }
            listOfCouriers.Items.Refresh();
            CourierJSONSerializer();
        }

        private void Courier_btnOkay_Click(object sender, RoutedEventArgs e)
        {
            AllOfCouriers.couriers.Add(
                        new Courier(
                            Courier_txtNameSurname.Text,
                            Courier_txtEmail.Text,
                            Courier_txtPhone.Text));
            listOfCouriers.SelectedIndex = AllOfCouriers.couriers.Count - 1;
            Courier_txtNameSurname.SelectAll();
            Courier_txtNameSurname.Focus();
            CourierJSONSerializer();
            MessageBox.Show("Kurier został dodany!");
        }

        private void Courier_btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Odrzucono.");
        }
        private void Courier_btnSummary_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zweryfikowano.");
        }
        //POBOCZNA FUNKCJONALNOŚĆ KURIER
        //KURIER
        






        //KLIENT
        //GŁÓWNA FUNKCJONALNOŚĆ KLIENTA
        private void AddClientClick(object sender, RoutedEventArgs e)
        {
            NewClient add = new NewClient();
            if (add.ShowDialog() == true)
            {
                string gender = ""; string type = ""; string term = "";

                /*
                if (add.male.IsChecked == true) gender = add.male.Content.ToString();
                if (add.female.IsChecked == true) gender = add.male.Content.ToString();
                if (add.unknown.IsChecked == true) gender = add.unknown.Content.ToString();

                if (add.Oplata.IsChecked == true) type = type + add.Oplata.Content.ToString() + " ";
                if (add.Charytatywne.IsChecked == true) type = type +  add.Charytatywne.Content.ToString() + " ";
                if (add.Napiwek.IsChecked == true) type = type + add.Napiwek.Content.ToString() + " ";
                if (type == "") type = "brak";

                if (add.Standard.IsChecked == true) term = add.Standard.Content.ToString();
                if (add.Ekspres.IsChecked == true) term = add.Ekspres.Content.ToString();
                */

                AllOfClients.Add(
                    new Client(
                        add.txtNameSurname.Text,
                        add.txtEmail.Text,
                        add.datepick.SelectedDate.ToString(),
                        add.cmbProvince.SelectedIndex.ToString(),
                        add.txtCity.Text,
                        add.txtStreet.Text,
                        add.txtCode.Text,
                        add.txtPhone.Text,
                        add.cmbGender.SelectedIndex.ToString(),
                        type,
                        term,
                        add.txtSummary.Text,
                        add.datepick.SelectedDate
                        ));
                listOfClients.SelectedIndex = AllOfClients.Count - 1;
                Client_txtNameSurname.SelectAll();
                Client_txtNameSurname.Focus();

                ClientJSONSerializer();


            }
        }

        private void ClientJSONSerializer()
        {
            //serializowanie listy klientów przy dodawaniu nowego

            using (StreamWriter sw = new StreamWriter(@"clients.txt"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                sw.WriteLine(JsonConvert.SerializeObject(AllOfClients));
            }

            listOfClients.Items.Refresh();
        }
        private Collection<Client> ClientJSONDeserializer()
        {
            Collection<Client> clients_col = new Collection<Client>();
            using (StreamReader sr = new StreamReader(@"clients.txt"))
            {
                clients_col = JsonConvert.DeserializeObject<Collection<Client>>(sr.ReadLine());
            }
            listOfClients.Items.Refresh();
            return clients_col;
        }
        private void EditClientClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Brak funkcjonalności, zadanie jest oparte na wiązaniach!");
        }

        private void DeleteClientClick(object sender, RoutedEventArgs e)
        {
            if (listOfClients.SelectedIndex >= 0)
            {
                if (MessageBox.Show(
                "Czy na pewno chcesz usunąć wskazanego klienta z listy?",
                "Usuń element", MessageBoxButton.YesNo,
                MessageBoxImage.Question) != MessageBoxResult.Yes)
                    return;
                AllOfClients.RemoveAt(listOfClients.SelectedIndex);
                listOfClients.Items.Refresh();
                ClientJSONSerializer();

            }

            if (listOfClients.Items.Count == 0)
            {
                EditClientButton.IsEnabled = false;
                DeleteClientButton.IsEnabled = false;
                ViewClientButton.IsEnabled = false;
                PrintClientButton.IsEnabled = false;
                MapClientButton.IsEnabled = false;
            }
            
        }

        private void ViewClientClick(object sender, RoutedEventArgs e)
        {
            if (listOfClients.SelectedIndex >= 0)
            {
                if (MessageBox.Show(listOfClients.SelectedItem.ToString(),
                "Szczegóły Klienta", MessageBoxButton.OK,
                MessageBoxImage.Information) != MessageBoxResult.Yes)
                    return;
            }
        }

        private void MapClientClick(object sender, RoutedEventArgs e)
        {
            string adres = Client_txtCode.Text + " " + Client_txtCity.Text + " " + Client_txtStreet.Text;
            MapWindow map = new MapWindow(adres);
            map.Show();
        }

        private void ClientGotFocus(object sender, RoutedEventArgs e)
        {
            EditClientButton.IsEnabled = true;
            DeleteClientButton.IsEnabled = true;
            ViewClientButton.IsEnabled = true;
            PrintClientButton.IsEnabled = true;
            MapClientButton.IsEnabled = true;
        }
        //GŁÓWNA FUNKCJONALNOŚĆ KLIENTA


        //POBOCZNA FUNKCJONALNOŚĆ KLIENTA
        private void Client_txtNameSurname_TextChanged(object sender, TextChangedEventArgs e) //przy zmianie imienia i nazwiska
        {
            if (Client_txtNameSurname.Text != "")
            {
                btnClientSummary.IsEnabled = true;
                btnClientOk.IsEnabled = true;
                btnClientCancel.IsEnabled = true;
                ClientJSONSerializer();
            }
            else
            {
                btnClientSummary.IsEnabled = false;
                btnClientOk.IsEnabled = false;
                btnClientCancel.IsEnabled = false;
            }

            Client @new = AllOfClients.FirstOrDefault(c =>
                c.Phone == (string)Client_txtPhone.Text &&
                c.Street == (string)Client_txtStreet.Text &&
                c.Code == (string)Client_txtCode.Text &&
                c.Email == (string)Client_txtEmail.Text &&
                c.City == (string)Client_txtCity.Text
                );

            foreach(var order in AllOfOrders)
            {
                if (order.ClientID.Contains(Client_txtEmail.Text) && order.ClientID.Contains(Client_datepick.Text))
                {
                    if(@new!=null) order.ClientID = @new.ToString();
                }
            }
            OrderJSONSerializer();
        }

        private void Client_btnOkay_Click(object sender, RoutedEventArgs e)
        {
            string gender = ""; string type = ""; string term = "";
            /*
            if (maleClient.IsChecked == true) gender = maleClient.Content.ToString();
            if (femaleClient.IsChecked == true) gender = femaleClient.Content.ToString();
            if (unknownClient.IsChecked == true) gender = unknownClient.Content.ToString();

            if (Client1.IsChecked == true) type = type + Client1.Content.ToString() + " ";
            if (Client2.IsChecked == true) type = type + Client2.Content.ToString() + " ";
            if (Client3.IsChecked == true) type = type + Client3.Content.ToString() + " ";

            if (StandardClient.IsChecked == true) term = StandardClient.Content.ToString();
            if (EkspresClient.IsChecked == true) term = EkspresClient.Content.ToString();
            */

            AllOfClients.Add(
                    new Client(
                        Client_txtNameSurname.Text,
                        Client_txtEmail.Text,
                        Client_datepick.SelectedDate.ToString(),
                        Client_cmbProvince.SelectedIndex.ToString(),
                        Client_txtCity.Text,
                        Client_txtStreet.Text,
                        Client_txtCode.Text,
                        Client_txtPhone.Text,
                        Client_cmbGender.SelectedIndex.ToString(),
                        type,
                        term,
                        txtClientSummary.Text,
                        Client_datepick.SelectedDate
                        ));
            listOfClients.SelectedIndex = AllOfClients.Count - 1;
            Client_txtNameSurname.SelectAll();
            Client_txtNameSurname.Focus();
            ClientJSONSerializer();
            MessageBox.Show("Klient został dodany!");
        }

        private void dateChangeHandler(object sender, RoutedEventArgs e)
        {
            Client @new = AllOfClients.FirstOrDefault(c =>
                c.NameSurname == Client_txtNameSurname.Text &&
                c.Phone == (string)Client_txtPhone.Text &&
                c.Street == (string)Client_txtStreet.Text &&
                c.Code == (string)Client_txtCode.Text &&
                c.Email == (string)Client_txtEmail.Text &&
                c.City == (string)Client_txtCity.Text

                );

            if (@new != null) @new.DateOfBirth = @new.DATEDateOfBirth.ToString();
            foreach (var order in AllOfOrders)
            {
                if (order.ClientID.Contains(Client_txtEmail.Text) && order.ClientID.Contains(Client_txtNameSurname.Text))
                {
                    if (@new != null) order.ClientID = @new.ToString();
                }
            }
            OrderJSONSerializer();
        }
        private void emailChangeHandler(object sender, RoutedEventArgs e)
        {
            
            Client old = AllOfClients.FirstOrDefault(c =>
                c.NameSurname == Client_txtNameSurname.Text &&
                c.Phone == (string)Client_txtPhone.Text &&
                c.Street == (string)Client_txtStreet.Text &&
                c.Code == (string)Client_txtCode.Text &&
                c.City == (string)Client_txtCity.Text
                );
            Client @new = new Client();
            if (old!=null) @new = old;
            @new.Email = Client_txtEmail.Text;

            foreach (var order in AllOfOrders)
            {
                if (order.ClientID.Contains(Client_datepick.Text) && order.ClientID.Contains(Client_txtNameSurname.Text))
                {
                    if (old != null) order.ClientID = @new.ToString();
                }
            }
            OrderJSONSerializer();
        }

        private void Client_btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Odrzucono");
        }
        private void Client_btnSummary_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zweryfikowano.");
        }
        
        //POBOCZNA FUNKCJONALNOŚĆ KLIENTA
        //KLIENT







        //TEMPLATE
        //GŁÓWNA FUNKCJONALNOŚĆ
        private void AddClick(object sender, RoutedEventArgs e)
        {
            NewPerson add = new NewPerson();
            if (add.ShowDialog() == true)
            {
                string gender = ""; string type = ""; string term = "";
                if (add.male.IsChecked == true) gender = add.male.Content.ToString();
                if (add.female.IsChecked == true) gender = add.male.Content.ToString();
                if (add.unknown.IsChecked == true) gender = add.unknown.Content.ToString();

                if (add.Oplata.IsChecked == true) type = type + add.Oplata.Content.ToString() + " ";
                if (add.Charytatywne.IsChecked == true) type = type + add.Charytatywne.Content.ToString() + " ";
                if (add.Napiwek.IsChecked == true) type = type + add.Napiwek.Content.ToString() + " ";
                if (type == "") type = "brak";

                if (add.Standard.IsChecked == true) term = add.Standard.Content.ToString();
                if (add.Ekspres.IsChecked == true) term = add.Ekspres.Content.ToString();

                AllOfPeople.Add(
                    new Person(
                        add.txtNameSurname.Text,
                        add.txtEmail.Text,
                        add.txtPayment.Text,
                        add.datepick.SelectedDate.ToString(),
                        add.cmbProvince.SelectedIndex.ToString(),
                        add.txtCity.Text,
                        add.txtStreet.Text,
                        add.txtCode.Text,
                        add.txtPhone.Text,
                        gender,
                        type,
                        term,
                        add.txtSummary.Text
                        ));
                listOfItems.SelectedIndex = AllOfPeople.Count - 1;
                txtNameSurname.SelectAll();
                txtNameSurname.Focus();
            }
        }

        private void EditClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Brak funkcjonalności, zadanie jest oparte na wiązaniach!");
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            if (listOfItems.SelectedIndex >= 0)
            {
                if (MessageBox.Show(
                "Czy na pewno chcesz usunąć wskazany element?",
                "Usuń element", MessageBoxButton.YesNo,
                MessageBoxImage.Question) != MessageBoxResult.Yes)
                    return;
                AllOfPeople.RemoveAt(listOfItems.SelectedIndex);
            }

            if (listOfItems.Items.Count == 0)
            {
                EditButton.IsEnabled = false;
                DeleteButton.IsEnabled = false;
                ViewButton.IsEnabled = false;
            }
        }

        private void ViewClick(object sender, RoutedEventArgs e)
        {
            if (listOfItems.SelectedIndex >= 0)
            {
                if (MessageBox.Show(listOfItems.SelectedItem.ToString(),
                "Szczegóły", MessageBoxButton.OK,
                MessageBoxImage.Information) != MessageBoxResult.Yes)
                    return;
            }
        }

        private void PersonGotFocus(object sender, RoutedEventArgs e)
        {
            EditButton.IsEnabled = true;
            DeleteButton.IsEnabled = true;
            ViewButton.IsEnabled = true;
        }
        //GŁÓWNA FUNKCJONALNOŚĆ


        //POBOCZNA FUNKCJONALNOŚĆ
        private void txtNameSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNameSurname.Text != "")
            {
                btnSummary.IsEnabled = true;
                btnOk.IsEnabled = true;
                btnCancel.IsEnabled = true;
            }
            else
            {
                btnSummary.IsEnabled = false;
                btnOk.IsEnabled = false;
                btnCancel.IsEnabled = false;
            }
        }

        private void scrollbarPayment_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtPayment.Text = ((int)scrollbarPayment.Value).ToString();
        }

        private void btnOkay_Click(object sender, RoutedEventArgs e)
        {
            string gender = ""; string type = ""; string term = "";
            if (male.IsChecked == true) gender = male.Content.ToString();
            if (female.IsChecked == true) gender = male.Content.ToString();
            if (unknown.IsChecked == true) gender = unknown.Content.ToString();

            if (Oplata.IsChecked == true) type = type + Oplata.Content.ToString() + " ";
            if (Charytatywne.IsChecked == true) type = type + Charytatywne.Content.ToString() + " ";
            if (Napiwek.IsChecked == true) type = type + Napiwek.Content.ToString() + " ";

            if (Standard.IsChecked == true) term = Standard.Content.ToString();
            if (Ekspres.IsChecked == true) term = Ekspres.Content.ToString();


            AllOfPeople.Add(
                    new Person(
                        txtNameSurname.Text,
                        txtEmail.Text,
                        txtPayment.Text,
                        datepick.SelectedDate.ToString(),
                        cmbProvince.SelectedIndex.ToString(),
                        txtCity.Text,
                        txtStreet.Text,
                        txtCode.Text,
                        txtPhone.Text,
                        gender,
                        type,
                        term,
                        txtSummary.Text
                        ));
            listOfItems.SelectedIndex = AllOfPeople.Count - 1;
            txtNameSurname.SelectAll();
            txtNameSurname.Focus();
            MessageBox.Show("Osoba została dodana!");
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Odrzucono");
        }
        private void btnSummary_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zweryfikowano.");
        }
        //POBOCZNA FUNKCJONALNOŚĆ
        //TEMPLATE

    }
}
