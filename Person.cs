using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WPF___Projekt
{
    public class Person : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this,
                new PropertyChangedEventArgs(property));
        }

        //Atrybuty
        private string namesurname;
        public string NameSurname
        {
            get { return namesurname; }
            set { namesurname = value; OnPropertyChanged("NameAndPrice"); }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged("NameAndPrice"); }
        }

        private string payment;
        public string Payment
        {
            get { return payment; }
            set { payment = value; OnPropertyChanged("NameAndPrice"); }
        }

        private string dateofbirth;
        public string DateOfBirth
        {
            get { return dateofbirth; }
            set { dateofbirth = value; OnPropertyChanged("NameAndPrice"); }
        }

        private string province;
        public string Province
        {
            get { return province; }
            set { province = value; OnPropertyChanged("NameAndPrice"); }
        }

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

        private string gender;
        public string Gender
        {
            get { return gender; }
            set { gender = value; OnPropertyChanged("NameAndPrice"); }
        }

        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; OnPropertyChanged("NameAndPrice"); }
        }

        private string term;
        public string Term
        {
            get { return term; }
            set { term = value; OnPropertyChanged("NameAndPrice"); }
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

        //Kontruktory
        public Person() { }
        public Person(string ns, string e)
        {
            NameSurname = ns;
            Email = e;
        }

        public Person(string ns, string e, string p)
        {
            NameSurname = ns;
            Email = e;
            Payment = p;
        }
        public Person(string ns, string e, string d, string p)
        {
            NameSurname = ns;
            Email = e;
            Payment = p;
            DateOfBirth = d;
        }
        public Person(string ns, string e, string pa, string d,
            string pr, string ci, string s, string co, string ph,
            string g, string ty, string te, string des)
        {
            NameSurname = ns;
            Email = e;
            Payment = pa;
            DateOfBirth = d;
            Province = pr;
            City = ci;
            Street = s;
            Code = co;
            Phone = ph;
            Gender = g;
            Type = ty;
            Term = te;
            Description = des;
        }


        //Metody
        public override string ToString()
        {
            return this.NameSurname + " " + this.Email + " " + this.DateOfBirth + " " + this.Payment;
        }
        public string PrintString()
        {
            return this.NameSurname.PadRight(25).Substring(0, 25) + " " + this.Email.PadRight(45).Substring(0, 35) + " " + this.DateOfBirth.PadRight(23).Substring(0, 23);
        }

        public string AllToString()
        {
            return this.NameSurname + " " + this.Email + " " + this.DateOfBirth + " " + this.Payment
                + "/n" + this.Province + " " + this.City + " " + " " + this.Street + " " + this.Phone
                + "/n" + this.Description;
        }
    }
}
