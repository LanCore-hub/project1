using Model;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class Logic
    {
        
        public List<Student> students { set; get; } = new List<Student>();

        public void AddStudent(string name, string speciality, string group)
        {
            bool flag = false;
            foreach (Student student in students)
            {
                if (student.Name == name && student.Speciality == speciality && student.Group == group)
                {
                    Console.WriteLine($"{name} {speciality} {group} уже есть!");
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                students.Add(new Student { Name = name, Speciality = speciality, Group = group });
                Console.WriteLine($"+ {name} {speciality} {group}");
            }
        }

        public void DeleteStudent(string name, string speciality, string group)
        {
            if (students.Count == 0)
                Console.WriteLine("Студентов всё равно нет.");
            foreach (Student student in students)
            {
                if (student.Name == name && student.Speciality == speciality && student.Group == group)
                {
                    students.Remove(student);
                    Console.WriteLine($"- {name} {speciality} {group}");
                    break;
                }
            }
        }
        public void DeleteStudent(int index)
        {
            if (students.Count == 0)
                Console.WriteLine("Студентов всё равно нет.");
            if (students.Count > index)
            {
                Console.WriteLine($"- {students[index].Name} {students[index].Speciality} {students[index].Group}");
                students.RemoveAt(index);
            }
            else
                Console.WriteLine($"Нет студентов с индексом {index}, введите число от 0 до {students.Count - 1}!");
        }

        public void View()
        {
            Console.WriteLine("\nВывод списка студентов");
            Console.WriteLine("-----------------------");
            if (students.Count != 0)
            {
                foreach (var isStudent in students)
                {
                    Console.WriteLine(isStudent.Name + " " + isStudent.Speciality + " " + isStudent.Group);
                }
            }
            else
                Console.WriteLine("Список пуст...");
            Console.WriteLine();
        }
    }
}
