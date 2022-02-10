using System;
using System.Collections.Generic;

namespace TelefonRehberiUygulaması
{
    class Contact {
        private string _firstName;
        private string _lastName;
        private string _phone;
        public Contact(string f_name, string l_name, string phone) {
            this._firstName=f_name;
            this._lastName=l_name;
            this._phone=phone;
        }
        
        public string getFirstName () {
            return this._firstName;
        }
        public string getLastName () {
            return this._lastName;
        }
        public string getPhone () {
            return this._phone;
        }
        public void setFirstName( string name) {
            this._firstName=name;
        }
        public void setLastName( string name) {
            this._lastName=name;
        }
        public void setPhone( string phone) {
            this._phone=phone;
        }
        public void ContactDetails() {
            Console.WriteLine("İsim: " + this._firstName);
            Console.WriteLine("Soyisim: " + this._lastName);
            Console.WriteLine("Telefon Numarası: " + this._phone);
        }

    }

}