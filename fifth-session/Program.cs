using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {



        static void Main(string[] args)
        {
            // int firstNumber = 4;
            // int secondNumber = 5;
            // int thirdNumber = 6;


            // Calculations(firstNumber, secondNumber, thirdNumber, out int multiplication, out int addition, out int subtraction);

            // Console.WriteLine($"Multiplication {multiplication}");
            // Console.WriteLine($"Addition {addition}");
            // Console.WriteLine($"Subtraction {subtraction}");


            int finalResult = Multiply(1,2,3);
            Console.WriteLine(finalResult);
            

        }

        public static int Multiply(params int[] Inputs){
            int result = 1;
                foreach (var item in Inputs)
                {
                    result *= item;
                }
            return result;
        }
        // public static void Calculations(int a, int b, int c, out int multiplication, out int addition, out int subtraction)
        // {
        //     addition = a + b + c;
        //     multiplication = a * c * b;
        //     subtraction = a - b - c;
        // }

    }
}