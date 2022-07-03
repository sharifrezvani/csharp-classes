using System;

namespace TenthSession // Note: actual namespace depends on the project name.
{

    // public static class Person
    // {
    //     public static string FirstName { get; set; }
    //     public static string LastName { get; set; }

    //     public static string FullName(string firstName, string lastName)
    //     {
    //         string fullName = $"{firstName} {lastName}";
    //         return fullName;
    //     }


    // }



    internal class Program
    {
        static void Main(string[] args)
        {


            // First Exercise ---------------------------------------------



            // Console.WriteLine("How many words do wanna give me?");
            // int iterations = Convert.ToInt32(Console.ReadLine());

            // List<string> words = new List<string>(iterations);

            // for (int i = 1; i <= iterations; i++)
            // {
            //     Console.WriteLine($"Enter word no.{i}:");
            //     string? newWord = Console.ReadLine();
            //     words.Add(newWord.ToUpper());
            // }

            // Console.WriteLine("Enter a character which you want to look for:");
            // char? targetChar = Convert.ToChar(Console.ReadLine().ToUpper());

            // foreach (var item in words)
            // {
            //     if (item[0] == targetChar)
            //     {
            //         Console.WriteLine($"\n{targetChar} is the first letter of {item}.");
            //     }

            //     if (item[item.Length - 1] == targetChar)
            //     {
            //         Console.WriteLine($"\n{targetChar} is the last letter of {item}.");
            //     }
            // }




            // Second Exercise ---------------------------------------




            // System.Console.WriteLine("Enter a number:");
            // string? number = Console.ReadLine();

            // int correctDifferenceCounter = 0;

            // for (var i = number.Length - 1; i >= 1; i--)
            // {
            //     int integerNumber = Convert.ToInt32(number[i]);
            //     int integerNumberTwo = Convert.ToInt32(number[i - 1]);



            //     if (integerNumber == integerNumberTwo + 2)
            //     {
            //         correctDifferenceCounter++;
            //     }
            // }

            // if (correctDifferenceCounter == (number.Length - 1))
            // {
            //     Console.WriteLine("Each digit is the next digit minus two.");
            // }
            // else
            // {
            //     Console.WriteLine("Each digit is not the next digit minus two.");
            // }



            // Third Exercise ---------------------------------------


            // Console.WriteLine(Person.FullName("Sharif", "Rezvani"));




            // Fourth Exercise ---------------------------------------

            string s = "123";

            Console.WriteLine(s.toInt32());

            int digit = Extensions.toInt32(s);

            Console.WriteLine(digit);
            
        }
    }

        public static class Extensions
    {
        public static int toInt32(this string a)
        {
            int result = Convert.ToInt32(a);

            return result;
        }
    }
}