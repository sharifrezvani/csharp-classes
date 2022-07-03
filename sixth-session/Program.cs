using System;
using System.Collections.Generic;
using System.Text;

namespace SixthSession
{
    class Program
    {



        static void Main(string[] args)
        {
            // FIRST EXERCISE





            // Console.WriteLine("Enter 10 numbers:");
            // List<int> numbers = new List<int>();
            // for (var i = 0; i <= 9; i++)
            // {
            //     int newNumber = Convert.ToInt32(Console.ReadLine());
            //     numbers.Add(newNumber);
            // }

            // numbers.Sort();

            // Console.WriteLine("Sorted Numbers");

            // foreach (var item in numbers)
            // {
            //     Console.WriteLine(item);

            // }



            // SECOND EXERCISE




            // Console.WriteLine("Enter a number(not 0):");

            // int number;

            // number = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Odd numbers:");

            // if (number > 0)
            // {
            //     for (int i = 0; i <= number; i++)
            //     {
            //         if (i % 2 == 1)
            //         {
            //             Console.WriteLine(i);
            //         }
            //     }
            // } else if (number < 0)
            // {
            //     for (int i = 0; i >= number; i--)
            //     {
            //         if (i % 2 == -1)
            //         {
            //             Console.WriteLine(i);
            //         }
            //     }
            // } else {
            //     Console.WriteLine("The number can't be zero!");

            // }





            // THIRD EXERCISE



            // Console.WriteLine("Enter the start of the range:");
            // int rangeStart = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter the end of the range:");
            // int rangeEnd = Convert.ToInt32(Console.ReadLine());



            // if (rangeStart > rangeEnd)
            // {
            //     for (int i = rangeStart; i >= rangeEnd; i--)
            //     {
            //         if (i % 2 == 1 || i % 2 == -1)
            //         {
            //             Console.WriteLine(i);
            //         }
            //     }
            // } else if (rangeStart < rangeEnd)
            // {
            //     for (int i = rangeStart; i <= rangeEnd; i++)
            //     {
            //         if (i % 2 == 1 || i % 2 == -1)
            //         {
            //             Console.WriteLine(i);
            //         }
            //     }
            // }



            // FOURTH EXERCISE




            // StringBuilder name = new StringBuilder();

            // name.Append("My name is Sharif Rezvani.");
            // name.AppendLine();
            // name.Append("And I'm 22 years old.");

            // Console.WriteLine(name);




            // FIFTH EXERCISE




            // bool job = false;

            // String advice = (job == true) ? "kheili ham aali" : "boro kar kon";

            // Console.WriteLine(advice);




            // SIXTH EXERCISE


            Console.WriteLine("Which planet do you want(Enter a number)?");

            int planet = Convert.ToInt32(Console.ReadLine());

            switch (planet)
            {
                case 1:
                    Console.WriteLine($"{Planets.Mercury}");
                    break;
                case 2:
                    Console.WriteLine($"{Planets.Venus}");
                    break;
                case 3:
                    Console.WriteLine($"{Planets.Earth}");
                    break;
                case 4:
                    Console.WriteLine($"{Planets.Mars}");
                    break;
                case 5:
                    Console.WriteLine($"{Planets.Saturn}");
                    break;
                case 6:
                    Console.WriteLine($"{Planets.Jupiter}");
                    break;
                case 7:
                    Console.WriteLine($"{Planets.Mercury}");
                    break;
                case 8:
                    Console.WriteLine($"{Planets.Neptune}");
                    break;
                case 9:
                    Console.WriteLine($"{Planets.Pluto}");
                    break;
                default:
                    Console.WriteLine("Try again!");
                    break;
            }


        }

        public enum Planets
        {

            Mercury = 1,
            Venus = 2,
            Earth = 3,
            Mars = 4,
            Saturn = 5,
            Jupiter = 6,
            Uranus = 7,
            Neptune = 8,
            Pluto = 9,

        }

    }
}