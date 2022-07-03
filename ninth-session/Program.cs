using System;

namespace NinthSession
{


    public struct Rectangle
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Rectangle(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int Surface()
        {
            int surface = X * Y;
            return surface;
        }
    }


    internal class Program
    {

        public static void Multiply(int x, int y)
        {
            int result = x * y;
            Console.WriteLine(result);
        }

        public static void Multiply(double x, int y)
        {
            double result = x * y;
            Console.WriteLine(result);
        }

        public static void Multiply(double x, double y)
        {
            double result = x * y;
            Console.WriteLine(result);
        }

        public static void Multiply(int x, double y)
        {
            double result = x * y;
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {

            // Rectangle Rec = new Rectangle(10, 15);
            // Console.WriteLine(Rec.Surface());

            Multiply(12, 10);
            Multiply(12.3, 10);
            Multiply(12, 10.7);
            Multiply(12.3, 10.7);

        }
    }
}