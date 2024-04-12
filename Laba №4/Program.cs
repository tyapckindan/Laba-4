using student;
using reader;

namespace student
{
    class Student
    {
        public string lastname_in = "underfined",
            num_group = "underfined";
        int age = 0;

        public Student(string lastname_in, string num_group, int age)
        {
            this.lastname_in = lastname_in;
            this.num_group = num_group;
            this.age = age;
        }

        public static void Print(string lastname, string num_group, int age)
        {
            Console.WriteLine($"Студент {lastname} группы {num_group}.\nВозраст: {age}");
        }
    }
}

 namespace reader
{
    class Reader
    {
        public string num_lib_card = "underfined",
            faculty = "underfined",
            num_phone = "underfined";
        string lastname = "underfined",
            birthday = "underfined";

        public Reader(string num_lib_card, string faculty, string num_phone, string lastname, string birthday)
        {
            this.num_lib_card = num_lib_card;
            this.faculty = faculty;
            this.num_phone = num_phone;
            this.lastname = lastname;
            this.birthday = birthday;
        }

        public static void takeBook(string lastname_in, int count_book) => Console.WriteLine($"{lastname_in} взял {count_book} книги.");
        public static void takeBook(string lastname_in, params string[] books)
        {
            Console.Write($"{lastname_in} взял книги:");
            for (int i = 0; i < books.Length; i++)
            {
                Console.Write($" {books[i]}");
            }
            Console.Write(".\n");
        }

        public static void returnBook(string lastname_in, int count_book) => Console.WriteLine($"{lastname_in} вернул {count_book} книги.");
        public static void returnBook(string lastname_in, params string[] books)
        {
            Console.Write($"{lastname_in} вернул книги:");
            for (int i = 0; i < books.Length; i++)
            {
                Console.Write($" {books[i]}");
            }
            Console.Write(".\n");
        }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
       Student[] students = new Student[3];
       students[0] = new("Бакаев А.С.", "22ИТ17", 20);
       students[1] = new("Печкин М.С.", "23ИТ21", 18);
       students[2] = new("Белый Ю.Т.", "21ИТ35", 19);

       Reader[] readers = new Reader[3];
       readers[0] = new("123A", "Технический", "+7769823514", "Бакаев", "04.04.2004");
       readers[1] = new("234Б", "Технический", "+7581473692", "Печкин", "05.05.2006");
       readers[2] = new("356В", "Технический", "+7456321798", "Белый", "06.06.2005");

       string[] books = { "Приключения", "Словарь", "Энциклопедия" };

        Reader.takeBook(students[0].lastname_in, books);
        Reader.takeBook(students[1].lastname_in, 3);

        Reader.returnBook(students[2].lastname_in, books);
        Reader.returnBook(students[2].lastname_in, 2);
    }
}