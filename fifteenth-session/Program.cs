using System;

namespace FifteenthSession
{

    internal class Program
    {
        static void Main(string[] args)
        {

            // First Exercise (Linq) -------------------------------------------------


            // List<string> textInputsList = new List<string>();


            // for (var i = 0; i < 3; i++)
            // {
            //     Console.WriteLine($"Enter a word:");
            //     textInputsList.Add(Console.ReadLine());
            // }

            // int desiredMaxLength;



            // Console.WriteLine($"Enter a number between 0 and 10");

            // desiredMaxLength = Convert.ToInt32(Console.ReadLine());

            // var resultList = from input in textInputsList
            //                  where input.Length < desiredMaxLength
            //                  select input;

            // foreach (var item in resultList)
            // {
            //     Console.WriteLine(item);
            // }


            // Second Exercise (delegates) -------------------------------------------------------------


            // CanVote canVoteDelegate;

            // canVoteDelegate = LegalAge;
            // canVoteDelegate += VotingIsPossible;
            // canVoteDelegate += Message;

            // Delegate[] delList = canVoteDelegate.GetInvocationList();


            // foreach (CanVote item in delList)
            // {
            //     if (item(19))
            //     {
            //         continue;
            //     }
            //     else
            //     {
            //         break;
            //     }
            // }



            // Third Exercise (delegates) -------------------------------------------------------------
            

        }

        public delegate bool CanVote(int age);
        
        
        // private static CanVote canVoteDelegate;


        public static bool LegalAge(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine($"true1");
                
                return true;
            }
            else
            {
                Console.WriteLine($"false1");
                
                return false;
            }
        }

        public static bool VotingIsPossible(int age)
        {
            if (age >= 20)
            {
                 Console.WriteLine($"true2");
                Console.WriteLine($"Your are over 20 and you can vote.");
            return true;
            }
            else
            {
                Console.WriteLine($"false2");
                return false;
            }
            
        }

        public static bool Message(int age)
        {
            Console.WriteLine($"Go ahead and vote!");
            return true;
        }
    }
}