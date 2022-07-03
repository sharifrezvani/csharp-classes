using System;

namespace TenthSession
{
    public class Device
    {
        public string Color { get; set; }
        public int Weight { get; set; }

        public Device(string color, int weight)
        {
            this.Color = color;
            this.Weight = weight;
        }

    }
}