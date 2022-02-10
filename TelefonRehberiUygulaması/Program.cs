using System;
using System.Collections.Generic;

namespace TelefonRehberiUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {   
            int operation=0;
            List<Contact> contactsList = new List<Contact>();
            ContactsOperations ops = new ContactsOperations();
            contactsList.Add(new Contact("Seda", "Demir", "05555555555"));
            contactsList.Add(new Contact("Gazihan", "Demir", "05555555455"));
            contactsList.Add(new Contact("Ece", "Demir", "05555555554"));
            contactsList.Add(new Contact("Nazlı", "Yılmaz", "05555555445"));

            do {
                ops.ViewOptions();
                operation = Convert.ToInt16(Console.ReadLine());
                switch(operation) {
                    case 1: 
                        ops.AddContact(contactsList);
                        break;
                    case 2: 
                        ops.DeleteContact(contactsList);
                        break;
                    case 3:
                        ops.UpdateContact(contactsList);
                        break;
                    case 4: 
                        ops.ViewContacts(contactsList);
                        break;
                    case 5: 
                        ops.ViewContact(contactsList);
                        break;
                }
        } while (Convert.ToInt16(operation) != 6 );
       

        }
    }
}