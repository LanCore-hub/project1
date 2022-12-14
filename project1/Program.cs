using Model;
using BusinessLogic;
using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic logic = new Logic();

            bool x = true;
            while (x)
            {
                Console.WriteLine("Список команд:");
                Console.WriteLine("1 - добавить студента,");
                Console.WriteLine("2 - удалить студента по данным,");
                Console.WriteLine("3 - удалить студента по индексу,");
                Console.WriteLine("4 - вывести список студентов,");
                Console.WriteLine("5 - выйти.");

                ConsoleKeyInfo key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("\nВведите Имя Специальность Группу студента через пробел:");
                        string[] NewStudent = Console.ReadLine().Split();
                        logic.AddStudent(NewStudent[0], NewStudent[1], NewStudent[2]);
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("\nВведите Имя Специальность Группу студента через пробел:");
                        string[] DelStudent = Console.ReadLine().Split();
                        logic.DeleteStudent(DelStudent[0], DelStudent[1], DelStudent[2]);
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("\nВведите индекс студента:");
                        if (Int32.TryParse(Console.ReadLine(),out int result))
                            logic.DeleteStudent(result);
                        else
                            Console.WriteLine("Индекс введен неправильно.");
                        break;
                    case ConsoleKey.D4:
                        logic.View();
                        break;
                    case ConsoleKey.D5:
                        x = false;
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}