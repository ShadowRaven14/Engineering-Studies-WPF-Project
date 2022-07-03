using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WPF___Projekt.models
{
    public class Courier : INotifyPropertyChanged
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

        //Atrybuty podstawowe
        private string namesurname;
        public string NameSurname
        {
            get { return namesurname; }
            set { namesurname = value; OnPropertyChanged("NameAndPrice"); }
        }

        //Atrybuty kontaktowe
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged("NameAndPrice"); }
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; OnPropertyChanged("NameAndPrice"); }
        }


        public string NameAndPrice
        {
            get
            {
                return ToString();
            }
        }


        //Konstruktory
        public Courier() { }
        public Courier(string ns)
        {
            NameSurname = ns;
        }
        public Courier(string ns, string e, string ph)
        {
            NameSurname = ns;
            Email = e;
            Phone = ph;
        }
        public string PrintString()
        {
            return this.NameSurname.PadRight(25).Substring(0, 25);
        }

        //Metody
        public override string ToString()
        {
            return this.NameSurname;
        }

    }
}
