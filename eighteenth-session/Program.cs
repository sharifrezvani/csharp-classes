using System;

namespace Eighteenthsession
{
    internal class Program
    {

        // public static async Task Delay()
        // {
        //     Console.WriteLine($"waiting...");
        //     await Task.Delay(10000);
        //     Console.WriteLine($"10 seconds went by...");

        //     Console.WriteLine($"done!");
        // }

        // public static async Task<int> AddUpToHundred()
        // {
        //     int result = 0;

        //     for (int i = 1; i <= 100; i++)
        //     {
        //         result += i;
        //     }

        //     ShowResult(result);

        //     return result;
        // }

        // public static async Task ShowResult(int result)
        // {
        //     Console.WriteLine($"The result is {result}");

        // }

        static void Main(string[] args)
        {

            // First Exercise -------------------------------


            // var delay = Delay();
            // int result = await AddUpToHundred();
            // await delay;



            // Second Exercise ------------------------------


            // With GC ======>


            // MakeGarbage();

            // GC.Collect();
            // GC.WaitForPendingFinalizers();

            // With IDisposable ======>


            // Garbage garbageObject = new Garbage();

            // garbageObject.Dispose();


            // With using ===========>

            // using (Garbage garbageObject = new Garbage())
            // {
            //     Console.WriteLine($"Garbage was used!");
            // }

        }

        public static void MakeGarbage()
        {
            Garbage garbageObject = new Garbage();
        }

    }



    public class Garbage : IDisposable
    {
        public Garbage()
        {
            Console.WriteLine($"Garbage was created!");
            
        }

        ~Garbage()
        {
            Console.WriteLine("GARBAGE REMOVED!");
        }

        public void Dispose()
        {
            Console.WriteLine($"Destroyed!");
            ;
        }
    }
}