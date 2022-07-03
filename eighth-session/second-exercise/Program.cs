using System;

namespace EightSession2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Teacher> teacherList = new List<Teacher>(1);
            List<Student> studentList = new List<Student>(4);
            for (var i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"\nEnter the teacher's first name:");
                    string? tFirstName = Console.ReadLine();
                    Console.WriteLine($"\nEnter the teacher's last name:");
                    string? tLastName = Console.ReadLine();
                    Console.WriteLine($"\nEnter the teacher's subject for today:");
                    string? tSubject = Console.ReadLine();
                    Teacher teacherObj = new Teacher(tFirstName, tLastName, tSubject);
                    teacherList.Add(teacherObj);
                }
                else
                {
                    Console.WriteLine($"\n{i}. Enter the student's first name:");
                    string? sFirstName = Console.ReadLine();
                    Console.WriteLine($"\n{i}. Enter the student's last name:");
                    string? sLastName = Console.ReadLine();
                    Console.WriteLine($"\n{i}. Enter the student's subject for today:");
                    string? sSubject = Console.ReadLine();
                    studentList.Add(new Student(sFirstName, sLastName, sSubject));
                }
            }


            foreach (var item in teacherList)
            {
                item.Explain();
            }
            foreach (var item in studentList)
            {
                item.Study();
            }


        }
    }
}