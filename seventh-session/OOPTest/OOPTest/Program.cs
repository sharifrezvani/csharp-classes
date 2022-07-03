using System;

namespace HelloWorld
{
    public class Salary
    {
        public Salary(int time, int wage)
        {
            
        }

        private int _hourlyWage;

        public int HourlyWage
        {
            get { return _hourlyWage; }
            set { _hourlyWage = value; }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}