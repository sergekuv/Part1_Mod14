using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_14_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int pageSize = 7;   //Количество записей, отображаемое на "странице"

            var phoneBook = new List<Contact>();

            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));
            //phoneBook.Add(new Contact("Ян", "Янович", 799900000013, "yaya@example.com"));

            // Доработайте вашу телефонную книгу из задания 14.2.10 предыдущего юнита так, чтобы контакты телефонной книги
            // были отсортированы сперва по имени, а затем по фамилии.
            // Хватит этой операции для выполнения требоввани задачи? Или правильнее делать как-то по-другому?
            var sortedBook = phoneBook.OrderBy(c => c.Name).ThenBy(c => c.LastName);

            // или можно так:
            //var sortedBook = from c in phoneBook orderby (c.Name, c.LastName) select c;

            Console.WriteLine($"-- Вот полное содержиние книги. Всего {sortedBook.Count()} записей, " +
                $"{(sortedBook.Count()%pageSize ==0 ? sortedBook.Count()/pageSize : sortedBook.Count()/pageSize + 1)}  страниц(ы)  ({pageSize} записей на странице)--");
            foreach (Contact c in sortedBook)
            {
                Console.WriteLine(c.Show());
            }
            Console.WriteLine();

            while (true)
            {
                Console.Write("\nВведите номер страницы для отображения (или нажмите Ctrl+C для завершения работы): " );
                //При введении отрицательного номера будет показана первая страница - это, кажется не должно быть проблемой. Ну, или нужно ввести проверку на положительность..
                if (Int32.TryParse(Console.ReadLine(), out int pageNumber) && pageSize * (pageNumber-1) < sortedBook.Count())
                {
                    var toShow = sortedBook.Skip(pageSize * (pageNumber -1)).Take(pageSize);
                    foreach (Contact c in toShow)
                    {
                        Console.WriteLine(c.Show());
                    }
                }
                else
                {
                    Console.WriteLine("\n--Номер слишком велик, или введен не номер--\n");
                }
            }

            Console.WriteLine("-- end --");
        }
    }
}
