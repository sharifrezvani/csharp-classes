using System;

namespace TenthSession
{
    public class Furniture
    {
        public string Color { get; set; }
        public int Weight { get; set; }

        public Furniture(string color, int weight)
        {
            this.Color = color;
            this.Weight = weight;
        }

    }
}