using System;

namespace EightSession

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter width:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height:");
            int height = Convert.ToInt32(Console.ReadLine());


            Rectangle rectangleObj = new Rectangle(width, height);
            
            Console.WriteLine($"The surface is {rectangleObj.CalculateSurface()}.");
            



        }
    }
}