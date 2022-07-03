using System;

namespace Income
{

    public class Salary
    {
        public Salary(int hours, int wage)
        {
            _hours = hours;
            _wage = wage;
        }


        private int _hours;
        public int Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }



        private int _wage;
        public int Wage
        {
            get { return _wage; }
            set { _wage = value; }
        }
        
        public int CalculateSalary()
        {
            int salary = _hours * _wage;
            return salary;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the hours you worked:");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your hourly wage (USD):");
            int wage = Convert.ToInt32(Console.ReadLine());
            

            Salary salaryObj = new Salary(hours, wage);

            Console.WriteLine($"You've made ${salaryObj.CalculateSalary()}.");
            


        }
    }
}