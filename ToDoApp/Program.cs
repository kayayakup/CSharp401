using System;
using System.Collections.Generic;
namespace todo_app_csharp
{
    class Program
    {
        static void Main(string[] args)
        {   
            TodoOperations ops = new TodoOperations();

            //Constructor format: 
            // str title, str content, int duration, int member_id, int status)
            Todo todo1 = new Todo("todo app", "c sharp", 2, 1, 1);
            Todo todo2 = new Todo("contacts app", "c#", 1, 2, 2);
            Todo todo3 = new Todo("coderbyte challange", "c sharp", 1, 2);
            
            List<Todo> todoList = new List<Todo>();

            todoList.Add(todo1);
            todoList.Add(todo2);
            todoList.Add(todo3);

            int operation = 0;
            do {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
                Console.WriteLine("*****************************************");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");
                Console.WriteLine("(5) Çıkış yapmak");
                
                operation = Convert.ToInt16(Console.ReadLine());
                switch(operation) {
                    case 1: 
                        ops.ViewTodoList(todoList);
                        break;
                    case 2: 
                        ops.AddTodo(todoList);
                        break;
                    case 3:
                        ops.DeleteTodo(todoList);
                        break;
                    case 4: 
                        ops.UpdateStatus(todoList);
                        break;
                }
        } while (Convert.ToInt16(operation) != 5  );
    
        }
    }
}