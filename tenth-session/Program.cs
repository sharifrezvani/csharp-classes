using System;

namespace TenthSession
{
    interface IExplode
    {
        public string Sound { get; set; }
        void Explode();
    }
    public abstract class Person
    {
        public abstract void WriteName();
    }

    public class Student: Person
    {
        public string Name { get; set; }
        public string Job { get; set; }

        public Student(string name, string job)
        {
            this.Name = name;
            this.Job = job;
        }

        public override void WriteName()
        {
            Console.WriteLine(Name);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Phone phoneObj = new Phone("black", 15);

            // phoneObj.Explode();

            // Door doorObj = new Door("red", 12);

            // doorObj.Explode();

            Student studentObj = new Student("John Doe", "Programmer");

            studentObj.WriteName();
        }
    }
}