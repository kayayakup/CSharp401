using System;
using System.Collections.Generic;
namespace contacts_app_csharp
{
    class ContactsOperations {
        public void ViewOptions() {
            Console.WriteLine();
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :");
            Console.WriteLine("******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("(6) Çıkış Yapmak");
            Console.WriteLine();
        }
        public void AddContact(List<Contact> contactList) {
            Console.WriteLine("Yeni Numara Kaydetmek");
            Console.WriteLine("Lütfen isim giriniz             :");
            string first_name = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz          :");
            string last_name = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz :");
            string phone = Console.ReadLine();
            Contact newContact = new Contact(first_name, last_name, phone);
            contactList.Add(newContact);
            Console.WriteLine("Kişi rehbere eklendi");
        }

        public void DeleteContact(List<Contact> contactList) {
            Console.WriteLine("Silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            Console.WriteLine("Lütfen isim giriniz   :");
            string first_name = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz:");
            string last_name = Console.ReadLine();
            var contact = contactList.Find( 
                x => x.getFirstName() == first_name ||
                x.getLastName() == last_name  );
            if(contact != null) {
                Console.WriteLine(contact.getFirstName() + " " + contact.getLastName() 
                + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                string confirmation = Console.ReadLine();
                if(confirmation == "y" || confirmation == "yes" ){
                    contactList.Remove(contact);
                    Console.WriteLine("Kişi rehberden silindi");
                }
            }
            else{
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                int option = Convert.ToInt16(Console.ReadLine());
                if (option == 2) {
                    DeleteContact(contactList);
                } 
            }
        }

        public void UpdateContact(List<Contact> contactList) {
            Console.WriteLine(" Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            Console.WriteLine("Lütfen isim giriniz    :");
            string first_name = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz :");
            string last_name = Console.ReadLine();

            var contact = contactList.Find( 
                x => x.getFirstName() == first_name ||
                x.getLastName() == last_name  );

            if(contact != null) {
                Console.WriteLine("Bulunan kişi: ");
                Console.WriteLine();
                Console.WriteLine("İsim".PadRight(15, ' ') + "Soyisim".PadRight(15, ' ') + "Telefon".PadRight(15, ' ') );
                Console.WriteLine("*".PadRight(44, '*'));
                Console.WriteLine(
                    contact.getFirstName().PadRight(15, ' ') 
                    + contact.getLastName().PadRight(15, ' ') 
                    + contact.getPhone().PadRight(15, ' '));

                //Güncellenecek veri isteniyor
                Console.WriteLine("Lütfen yeni isim giriniz    :");
                string new_first_name = Console.ReadLine();
                Console.WriteLine("Lütfen yeni soyisim giriniz :");
                string new_last_name = Console.ReadLine();
                Console.WriteLine("Lütfen yeni numara giriniz :");
                string new_phone = Console.ReadLine();
                if (new_first_name != "" || new_last_name != "" || new_phone != "" ) {
                    if(new_first_name != "") {
                        contact.setFirstName(new_first_name); }
                    if(new_last_name != "") {
                        contact.setLastName(new_last_name); }
                    if(new_phone != "") {
                        contact.setPhone(new_phone);}

                    Console.WriteLine("Güncelleme tamamlandı");
                }
         }
         else {
            Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Güncellemeyi sonlandırmak için:(1)");
            Console.WriteLine("* Yeniden denemek için          :(2)");
            int option = Convert.ToInt16(Console.ReadLine());
                if (option == 2) {
                    UpdateContact(contactList);
                }
         }
        }

        public void ViewContacts(List<Contact> contactList) {
            Console.WriteLine("Rehberi Listelemek");
            Console.WriteLine("*".PadRight(44, '*'));
            Console.WriteLine("İsim".PadRight(15, ' ') + "Soyisim".PadRight(15, ' ') + "Telefon".PadRight(15, ' ') );
            Console.WriteLine();
            foreach (var item in contactList) 
                {
                    Console.WriteLine(
                        item.getFirstName().PadRight(15, ' ') 
                        + item.getLastName().PadRight(15, ' ') 
                        + item.getPhone().PadRight(15, ' '));
                }
        }

        public void ViewContact(List<Contact> contactList) {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine(" **********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            int option = Convert.ToInt16(Console.ReadLine()); 
            if (option==1) {
                Console.WriteLine("Lütfen isim giriniz   :");
                string first_name = Console.ReadLine();
                Console.WriteLine("Lütfen soyisim giriniz:");
                string last_name = Console.ReadLine();

                var contact = contactList.Find( 
                x => x.getFirstName() == first_name ||
                x.getLastName() == last_name );
                if(contact!=null) {
                    Console.WriteLine("Bulunan Kişi: ");
                    Console.WriteLine();
                    Console.WriteLine("İsim".PadRight(15, ' ') + "Soyisim".PadRight(15, ' ') + "Telefon".PadRight(15, ' ') );
                    Console.WriteLine("*".PadRight(44, '*'));
                    
                    Console.WriteLine(
                    contact.getFirstName().PadRight(15, ' ') 
                    + contact.getLastName().PadRight(15, ' ') 
                    + contact.getPhone().PadRight(15, ' '));

                }
                else {
                    Console.WriteLine("Kişi bulunamadı");
                }
            }
            else if (option ==2) {
                Console.WriteLine("Lütfen telefon numarası giriniz:");
                string phone = Console.ReadLine();
                var contact = contactList.Find( 
                x => x.getPhone() == phone );
                
                if(contact!=null) {
                    Console.WriteLine("Bulunan kişi: ");
                    Console.WriteLine();
                    Console.WriteLine("İsim".PadRight(15, ' ') + "Soyisim".PadRight(15, ' ') + "Telefon".PadRight(15, ' ') );
                    Console.WriteLine("*".PadRight(44, '*'));
                    
                    Console.WriteLine(
                    contact.getFirstName().PadRight(15, ' ') 
                    + contact.getLastName().PadRight(15, ' ') 
                    + contact.getPhone().PadRight(15, ' '));
                }
                else {
                    Console.WriteLine("Kişi bulunamadı");
                }
            }
        }
    }   
}