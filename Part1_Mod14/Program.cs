using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Part1_Mod14
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };

            //Array.Sort(people);
            //List<string> l = new();
            //foreach(string s in people)
            //{
            //    if(s[0] == 'А')
            //    {
            //        l.Add(s);
            //    }
            //}

            //foreach (string s in l)
            //{
            //    Console.WriteLine(s);
            //}

            //Console.WriteLine();
            ////var selectedPeople = from p in people // промежуточная переменная p 
            ////                     where p.StartsWith("А") // фильтрация по условию
            ////                     orderby p // сортировка по возрастанию (дефолтная)
            ////                     select p; // выбираем объект и сохраняем в выборку

            //var selected = from p in people
            //               where p.StartsWith("А")
            //               orderby p
            //               select p;

            //foreach (string s in selected)
            //    Console.WriteLine(s);

            //var nums = new List<int>() { 2, 9, 7, 6 };
            //var orderedNums = nums.OrderBy(n => n).Where(n => n > 6);//.All(n => n>1);

            //foreach (int n in orderedNums)
            //{
            //    Console.WriteLine(n);
            //}

            //var employees = new List<Employee>
            //{
            //   new Employee {Name="Иван", DepartMent= "Продажи" },
            //   new Employee {Name="Алла", DepartMent="Продажи" },
            //   new Employee {Name="Анна", DepartMent="Продажи" },
            //   new Employee {Name="Кирилл", DepartMent="Разработка" },
            //   new Employee {Name="Дмитрий", DepartMent="Разработка" },
            //   new Employee {Name="Алег", DepartMent="Разработка" },
            //};

            //// группируем сотрудников по департаменту
            //var groups = employees
            //   .GroupBy(e => e.DepartMent);

            //foreach (var group in groups)
            //{
            //    Console.WriteLine(group.Key);

            //    foreach (var e in group)
            //        Console.WriteLine(e.Name);

            //    Console.WriteLine();
            //}

            //var a = employees.Where(e => e.Name.StartsWith("А")).OrderBy(e => e.Name);

            //foreach (var v in a)
            //{
            //    Console.WriteLine(v.Name);
            //}

            //Console.WriteLine();
            //var l2 = from e in employees
            //         where e.Name.StartsWith("А")
            //         orderby e.DepartMent
            //         select e.Name;

            //foreach (var item in l2)
            //{
            //    Console.WriteLine(item);
            //}


            //var listOne = new List<int>() { 7, 2, 3 };
            //var listTwo = new List<int>() { 2, 8 };

            //var result = listOne.Zip(listTwo, (b,a) => b);
            //foreach (var v in result)
            //{
            //    Console.WriteLine(v);
            //}

            //Console.WriteLine();
            //var objects = new List<object>() { 1, "Сергей", "Андрей", 300};

            //var l3 = from o in objects
            //         where o is string
            //         orderby o
            //         select o;
            //foreach (var l in l3)
            //{
            //    Console.WriteLine(l);
            //}


            //foreach (var l4 in  objects.Where(o => o is string).OrderBy(o => o))
            //{
            //    Console.WriteLine(l4);
            //}

            //    int[] numbers = {1,    2, 4,6,9,11,12,14,22, 33, 55,88  };

            //    var evenNums = from i in numbers
            //                   where i % 2 == 0 && i > 10
            //                   select i;

            //    foreach (int i in evenNums)
            //        Console.WriteLine(i);

            //Console.WriteLine();
            //foreach (var e2 in numbers.Where(n => n % 2 == 0 && n > 10))
            //{
            //    Console.WriteLine(e2);
            //}

            //var russianCities = new List<City>();
            //russianCities.Add(new City("Москва", 11900000));
            //russianCities.Add(new City("Санкт-Петербург", 4991000));
            //russianCities.Add(new City("Волгоград", 1099000));
            //russianCities.Add(new City("Казань", 1169000));
            //russianCities.Add(new City("Севастополь", 449138));

            //foreach (var c in russianCities.Where(c => c.Name.Length <= 10).OrderBy(c => c.Name.Length))
            //{
            //    Console.WriteLine(c.Name);
            //}

            //var c1 = from c in russianCities
            //         where c.Name.Length <= 10
            //         orderby (c.Name.Length)
            //         select c;
            //foreach (var b in c1)
            //{
            //    Console.WriteLine(b.Name);
            //}

            // Словарь для хранения стран с городами
            //var Countries = new Dictionary<string, List<City>>();

            //// Добавим Россию с её городами
            //var russianCities = new List<City>();
            //russianCities.Add(new City("Москва", 11900000));
            //russianCities.Add(new City("Санкт-Петербург", 4991000));
            //russianCities.Add(new City("Волгоград", 1099000));
            //russianCities.Add(new City("Казань", 1169000));
            //russianCities.Add(new City("Севастополь", 449138));
            //Countries.Add("Россия", russianCities);

            //// Добавим Беларусь
            //var belarusCities = new List<City>();
            //belarusCities.Add(new City("Минск", 1200000));
            //belarusCities.Add(new City("Витебск", 362466));
            //belarusCities.Add(new City("Гродно", 368710));
            //Countries.Add("Беларусь", belarusCities);

            //// Добавим США
            //var americanCities = new List<City>();
            //americanCities.Add(new City("Нью-Йорк", 8399000));
            //americanCities.Add(new City("Вашингтон", 705749));
            //americanCities.Add(new City("Альбукерке", 560218));
            //Countries.Add("США", americanCities);


            //var mc = from cn in Countries
            //         from ci in cn.Value
            //         where ci.Population > 1_000_000
            //         orderby ci.Population descending
            //         select ci;

            //foreach (var item in mc)
            //{
            //    Console.WriteLine(item.Name + " " + item.Population);
            //}




            //Console.WriteLine();

            //string[] text = { "Раз два три",    "четыре пять шесть",    "семь восемь девять" };

            //var pst = from string s in text
            //          from string st in s.Split()
            //          select st;

            //foreach (var item in pst)
            //{
            //    Console.WriteLine(item);
            //}

            //         List<Student> students = new List<Student> { 
            //             new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
            //             new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
            //             new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
            //             new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            //         };

            //         var st3 = from stud in students
            //                   select new
            //                   {
            //                       fName = stud.Name,
            //                       yearOfB = DateTime.Now.Year - stud.Age
            //                   };

            //         foreach (var s in st3)
            //         {
            //             Console.WriteLine(s.fName + " " + s.yearOfB);
            //         }

            //         var st4 = students.Select(stu => new { fn = stu.Name, yb = DateTime.Now.Year - stu.Age }).OrderBy(stu => stu.yb);
            //         foreach (var s in st4)
            //         {
            //             Console.WriteLine(s.fn + " " + s.yb);
            //         }

            //         var stl = from stud in students
            //                   where stud.Age < 28
            //                   where stud.Languages.Contains("английский")
            //                   select stud;

            //         foreach (Student s in stl)
            //         {
            //             Console.WriteLine($"{s.Name} {s.Age} {s.Languages[0]}");
            //         }


            //         var st2 = students.Where(s => s.Age < 28).Where(s => s.Languages.Contains("английский"));
            //         foreach (Student s in st2)
            //         {
            //             Console.WriteLine($"{s.Name} {s.Age} {s.Languages[0]}");
            //         }


            //         var selectedStudents = students.SelectMany(
            //    // коллекция, которую нужно преобразовать
            //    s => s.Languages,
            //    // функция преобразования, применяющаяся к каждому элементу коллекции
            //    (s, l) => new { Student = s, Lang = l })
            //// дополнительные условия                          
            //.Where(s => s.Lang == "английский" && s.Student.Age < 28)
            //// указатель на объект выборки
            //.Select(s => s.Student);

            //         // Выведем результат
            //         foreach (Student student in selectedStudents)
            //             Console.WriteLine($"{student.Name} - {student.Age}");


            //         var companies = new Dictionary<string, string[]>();

            //         companies.Add("Apple", new[] { "Mobile", "Desktop" });
            //         companies.Add("Samsung", new[] { "Mobile" });
            //         companies.Add("IBM", new[] { "Desktop" });

            //         foreach (var c in companies.Where(co => co.Value.Contains("Mobile")))
            //         {
            //             Console.WriteLine(c.Key);
            //         }


            //         var numsList = new List<int[]>() {
            //             new[] {2, 3, 7, 1},
            //             new[] {45, 17, 88, 0},
            //             new[] {23, 32, 44, -6},
            //         };

            //         var n = from i1 in numsList
            //                   from i2 in i1
            //                   orderby i2
            //                   select i2;

            //         foreach (int i in n)
            //         {
            //             Console.WriteLine(i);
            //         }

            //         Console.WriteLine();
            //         var n2 = numsList.SelectMany(n => n).OrderBy(m => m);
            //         foreach (var y in n2)
            //         {
            //             Console.WriteLine(y.ToString());
            //         }

            //string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };

            //var wl = from w in words
            //         orderby w.Length
            //         select new
            //         {
            //             n = w
            //         };

            //foreach (var item in wl)
            //{
            //    Console.WriteLine(item.n);
            //}

            //var wl2 = words.OrderBy(w => w.Length).Select(w => new { name = w });

            //foreach (var it in wl2)
            //{
            //    Console.WriteLine(it.name);
            //}


            //var wordsInfo = words.Select(w => new { name = w, Length = w.Length }).OrderBy(word => word.Length); //  сортируем коллекцию по длине
            //foreach (var it in wordsInfo)
            //{
            //    Console.WriteLine(it.name + " " + it.Length);
            //}


            //var fullNameStudents = from s in students
            //                           // временная переменная для генерации полного имени
            //                       let fullName = s.Name + " Иванов"
            //                       // проекция в новую сущность с использованием новой переменной
            //                       select new
            //                       {
            //                           Name = fullName,
            //                           Age = s.Age
            //                       };

            //foreach (var stud in fullNameStudents)
            //    Console.WriteLine(stud.Name + ", " + stud.Age);

            //var st5 = from s in students
            //          where s.Age <27
            //          let byr = DateTime.Now.Year - s.Age
            //          select new Application
            //          {
            //              Name = s.Name,
            //              YearOfBirth = byr
            //          };

            //Console.WriteLine("Hello World!");
            //foreach (Application a in st5)
            //{
            //    Console.WriteLine(a.Name + " " + a.YearOfBirth);
            //}


            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            while (true)
            {
                Console.Write("Введите номер ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(n%3);
                var toShow = phoneBook.Skip(2*(n%3)).Take(2);
                foreach (var it in toShow)
                {
                    Console.WriteLine(it.Name + " - " + it.PhoneNumber);
                }

            }

            Console.WriteLine("end");
        }
    }
    public class Contact // модель класса
{
    public Contact(string name, string lastName, long phoneNumber, String email) // метод-конструктор
    {
        Name = name;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public String Name { get; }
    public String LastName { get; }
    public long PhoneNumber { get; }
    public String Email { get; }
}

//internal class Contact
//{
//    public Contact()
//    {
//    }

//    public string Name { get; set; }
//    public long Phone { get; set; }
//}

public class Course
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
    }

    public class Application
    {
        public string Name { get; set; }
        public int YearOfBirth { get; set; }
    }

    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Languages { get; set; }
    }

    public class City
    {
        public City(string name, long population)
        {
            Name = name;
            Population = population;
        }

        public string Name { get; set; }
        public long Population { get; set; }
    }

    class Employee
    {
        public string Name { get; set; }
        public string DepartMent { get; set; }
    }
}
