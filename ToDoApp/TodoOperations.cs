using System;
using System.Collections.Generic;
namespace todo_app_csharp
{
    class TodoOperations
    {   

        public void ViewTodoList(List<Todo> todoList) {
            Console.WriteLine();
            FindResults(todoList, 0); // View "Todo" line
            FindResults(todoList, 1); // View "In progress" line
            FindResults(todoList, 2); // View "Done" line
        }
        public void FindResults(List<Todo> todoList, int status) {
            // List todos based on their status (TODO, IN POGRESS, DONE)
            List<Todo> results = todoList.FindAll(todo=> todo.GetStatus() == status);
            if(status==0){
                Console.WriteLine("TODO Line");
                Console.WriteLine("************************");
            }
            else if(status==1) {
                Console.WriteLine("IN PROGRESS Line");
                Console.WriteLine("************************");
            }
            else if(status==2) {
                Console.WriteLine("DONE Line");
                Console.WriteLine("************************");
            }

            if (results.Count==0) {
                Console.WriteLine("~ BOŞ ~");
                Console.WriteLine();
            }
            else {
                foreach (var todo in results) {
                    todo.TodoDetails();
                    Console.WriteLine();
                }
            }

        }
    
        public void AddTodo(List<Todo> todoList) {
            Console.WriteLine();
            Console.Write("Başlık Giriniz                                  :");
            string title = Console.ReadLine();
            Console.WriteLine();
            Console.Write("İçerik Giriniz                                  :");
            string content = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            int drtn = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Kişi Seçiniz                                    :");
            try {
                int person = Convert.ToInt16(Console.ReadLine()); 
                todoList.Add(new Todo(title, content, drtn, person));
                Console.WriteLine();
                ViewTodoList(todoList);
            }
            catch {
                Console.WriteLine("Hatalı girişler yaptınız!");
            }      
        }
        public void UpdateStatus(List<Todo> todoList) {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız: ");
            string input = Console.ReadLine();

            List<Todo> result = todoList.FindAll(x=> x.GetTitle() == input);

            if(result.Count != 0 ){
                Console.WriteLine();
                Console.WriteLine("Bulunan Kart Bilgileri:");
                Console.WriteLine("**************************************");
                Console.WriteLine();
                foreach (Todo item in result)
                {   
                    item.TodoDetails();
                    if(item.GetStatus()==0) {Console.WriteLine("Line        :" + "TODO");}
                    else if(item.GetStatus()==1) {Console.WriteLine("Line        :" + "IN PROGRESS");}
                    else if(item.GetStatus()==2) {Console.WriteLine("Line        :" + "DONE");}
                }
                Console.WriteLine();
                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");
                int option = Convert.ToInt16(Console.ReadLine());
                if(option == 1 || option==2 || option==3) { 
                    option--;
                    todoList.Find(x=> x.GetTitle() == input).SetStatus((option));
                    Console.WriteLine("Taşıma işlemi tamamlandı");
                    ViewTodoList(todoList);
                }
                else {Console.WriteLine("Hatalı bir seçim yaptınız!");}    
            }
            else {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                int option = Convert.ToInt16(Console.ReadLine());
                if(option == 2) { UpdateStatus(todoList);}
                else {Console.WriteLine("Taşıma işlemi iptal edildi.");}
            }
        }

        public void DeleteTodo(List<Todo> todoList){
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız: ");
            string input = Console.ReadLine();

            List<Todo> result = todoList.FindAll(x=> x.GetTitle() == input);

            if(result.Count != 0 ){
                foreach (Todo item in result)
                {
                    todoList.Remove(item);
                }
                Console.WriteLine("Silme işlemi tamamlandı");
            }
            else {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                int option = Convert.ToInt16(Console.ReadLine());
                if(option == 2) { DeleteTodo(todoList);}
                else {Console.WriteLine("Silme işlemi iptal edildi.");}
            }
            
        }

    }
}