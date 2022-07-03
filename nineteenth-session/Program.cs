using System;
using System.Diagnostics;
using System.Collections;

namespace NineteenthSession
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };


            List<int> numbersList = ShowNumbers();
        }

        public static List<int> ShowNumbers()
        {

            List<int> numbersList = new List<int>();

            Hashtable openWith = new Hashtable();

            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();



            for (var i = 0; i < 5000; i++)
            {
                int result = i * 5 * 2;

                numbersList.Add(result);
            }

            sw.Stop();

            Console.WriteLine(sw.Elapsed.TotalMilliseconds);

            return numbersList;



        }
    }
}