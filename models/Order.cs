using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WPF___Projekt.models
{
    public class Order : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this,
                new PropertyChangedEventArgs(property));
        }


        //ID
        private long id;
        public long ID
        {
            get { return id; }
            set { id = value; OnPropertyChanged("NameAndPrice"); }
        }

        //Atrybuty stałe podstawowe
        private string namesurname;
        public string NameSurname
        {
            get { return namesurname; }
            set { namesurname = value; OnPropertyChanged("NameAndPrice"); }
        }

        private string courierid;
        public string CourierID
        {
            get { return courierid; }
            set { courierid = value; OnPropertyChanged("NameAndPrice"); }
        }

        private string clientid;
        public string ClientID
        {
            get { return clientid; }
            set { clientid = value; OnPropertyChanged("NameAndPrice"); }
        }

        private string payment;
        public string Payment
        {
            get { return payment; }
            set { payment = value; OnPropertyChanged("NameAndPrice"); }
        }


        //Śledzenie przesyłki
        private string packageStatus;
        public string PackageStatus
        {
            get { return packageStatus; }
            set { packageStatus = value; OnPropertyChanged("NameAndPrice"); }
        }

        private string bonus;
        public string Bonus
        {
            get { return bonus; }
            set { bonus = value; OnPropertyChanged("NameAndPrice"); }
        }

        private string arriveWhen;
        public string ArriveWhen
        {
            get { return arriveWhen; }
            set { arriveWhen = value; OnPropertyChanged("NameAndPrice"); }
        }


        //Śledzenie przesyłki
        private string city;
        public string City
        {
            get { return city; }
            set { city = value; OnPropertyChanged("NameAndPrice"); }
        }

        private string street;
        public string Street
        {
            get { return street; }
            set { street = value; OnPropertyChanged("NameAndPrice"); }
        }

        private string code;
        public string Code
        {
            get { return code; }
            set { code = value; OnPropertyChanged("NameAndPrice"); }
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; OnPropertyChanged("NameAndPrice"); }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; OnPropertyChanged("NameAndPrice"); }
        }



        public string NameAndPrice
        {
            get
            {
                return ToString();
            }
        }


        //Konstruktory
        public Order() { }

        public Order(string ns, string courier, string client, string pa)
        {
            NameSurname = ns;
            CourierID = courier;
            ClientID = client;
            Payment = pa;
        }

        public Order(string ns, string courier, string client, string pa, 
            string ps, string b, string aw, 
            string ci, string s, string co, string ph, string des)
        {
            NameSurname = ns;
            CourierID = courier;
            ClientID = client;
            Payment = pa;

            PackageStatus = ps;
            Bonus = b;
            ArriveWhen = aw;

            City = ci;
            Street = s;
            Code = co;
            Phone = ph;

            Description = des;
        }

        public string PrintString()
        {
            return this.NameSurname.PadRight(40).Substring(0, 40) + " " + this.CourierID.PadRight(20).Substring(0, 20) 
                + " " + this.ClientID.PadRight(30).Substring(0, 30) + " " + this.Payment.PadRight(10).Substring(0, 10);
        }

        //Metody
        public override string ToString()
        {
            return this.NameSurname + " " + this.Payment;
        }


    }
}
