using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryHomework
{
    class Program
    {
        static void Main(string[] args) /* система ведения учета книг.  С помощью while true зацикливаем, 
            создаем бесконечный цикл, чтобы выйти из цикла - используем return,  */
        {
        }
        public static string Login()
        {
            Console.WriteLine("Введите пароль: "); //user - 111. admin - 000
            String password = Console.ReadLine();
            if (password == "111") { }
            else if (password == "000") { }
            else
            {
                Console.WriteLine("Неверный пароль. Попробуйте еще раз.");
            }
            return "";
        }
        public static string Admin_Menu()
        {
            Console.WriteLine("Выберите действие: " +
                "Чтобы добавить книгу, нажмите 1" +
                "Чтобы удалить книгу, нажмите 2 ");
            String admin = Console.ReadLine();
            if (admin == "1") { }
            else if (admin == "2") { }
            else { Console.WriteLine("Вы выбрали несуществующее действие.");}
            return "";
        }
        public static string User_Menu()
        {
            Console.WriteLine("Выберите действие:" +
                "Если Вы хотите просмотреть список книг - нажмите 1" +
                "Если Вы хотите взять книгу - нажмите 2" +
                "Если Вы хотите вернуть книгу - нажмите 3");
            string user = Console.ReadLine();
            if (user == "1") { }
            else if (user == "2") { }
            else if (user == "3") { }
            else
            {
                Console.WriteLine("Вы выбрали несуществующее действие.");
            }
            return "";
        }
        public static string BooksList() // сделать действие - "Если хотите выйти в меню - нажмите 0, для админа и юзера - отдельно.
        {
            int[] book = new int[5];//не динамический массив
            book[0] = book1;
            book[1] = book2
            book[2] = book3;
            book[3] = book4;
            book[4] = book5;
            // должен быть динамический массив, чтобы его можно было принять из метода и его выводить на экран. 
            //для того, чтобы админ мог удалять/добавлять книги пользователь может брать/возвращать книги.          
            return "";
        }
         
        //  while (true) //создаем цикл 
        //    result = Login()  //показываем результат 

    }
}
