using System;
using Newtonsoft.Json;

namespace SeventeenthSession
{

    public static class Dumper
    {
        public static string ToPrettyString(this object value)
        {
            return JsonConvert.SerializeObject(value, Formatting.Indented);
        }

        public static T Dump<T>(this T value)
        {
            Console.WriteLine(value.ToPrettyString());
            return value;
        }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Shape(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public virtual void Draw()
        {
            System.Console.WriteLine($"__SHAPE__{this.Width}, {this.Height}");
        }
    }

    public class Square : Shape
    {
        public Square(int width, int height) : base(width, height)
        {

        }

        public override void Draw()
        {
            System.Console.WriteLine($"__SQUARE__{this.Width}, {this.Height}");
        }

        public void FillSquare()
        {
            Console.WriteLine($"Filling SQUARE at {this.Width}, {this.Height}");
        }
    }

    public class Circle : Shape
    {
        public Circle(int width, int height) : base(width, height)
        {

        }

        public override void Draw()
        {
            System.Console.WriteLine($"__CIRCLE__{this.Width}, {this.Height}");
        }

        public void FillCircle()
        {
            Console.WriteLine($"Filling CIRCLE at {this.Width}, {this.Height}");
        }
    }


    internal class Program
    {
        static async Task Main(string[] args)
        {

            // First Exercise (Async/Await)--------------------------------------------------



            // await ShowAdditionResult();




            // Second Exercise (Upcasting/Downcasting)--------------------------------------------------

            // Shape shapeObject = new Shape(12, 13);
            // shapeObject.Draw();

            // Square squareObject = new Square(14, 15);
            // squareObject.Draw();

            // Circle circleObject = new Circle(124, 53);
            // circleObject.Draw();

            // ==================

            // Shape[] shapes = new Shape[3];
            // shapes[0] = new Shape(100, 100);
            // shapes[1] = new Square(200, 200);
            // shapes[2] = new Circle(300, 300);
            // foreach (Shape shape in shapes)
            // {
            //     shape.Draw();
            // }

            // Shape shapeObject = new Circle(13, 312);
            // shapeObject.Draw();

            // Circle circleObject = (Circle)shapeObject;

            // circleObject.Width = 134;

            // shapeObject.Width = 1235;

            // circleObject.FillCircle();

            await MakeTeaAsync();

        }

        public static async Task<string> MakeTeaAsync()
        {
            var boilingWater = BoilWaterAsync();

            "take the cups out".Dump();

            "pour tea in cups".Dump();

            var water = await boilingWater;

            var tea = $"pour {water} in cups".Dump();
            
            return tea;
        }

        public static async Task<string> BoilWaterAsync()
        {
            "turn the kettle on".Dump();

            "waiting for the water to boil".Dump();

            await Task.Delay(10000);

            "the water is boiling".Dump();

            return "water";
        }


        // public static async Task<string> DelaySixtySeconds()
        // {
        //     "Counting from 1 to 60...".Dump();
        //     await Task.Delay(60000);
        //     return "Method 1 counted from 60";
        // }

        // public static async Task<string> OneUpTpHundred()
        // {

        //     int result = 0;

        //     for (var i = 0; i <= 100; i++)
        //     {
        //         result = +i;
        //     }

        //     result.Dump();
        //     return result.ToString();
        // }

        // public static async Task<string> ShowAdditionResult()
        // {

        //     await DelaySixtySeconds();

        //     return "Done!";
        // }
    }
}