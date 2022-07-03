using System;

namespace TenthSession
{
    public class Door : Furniture, IExplode
    {
        public string Color { get; set; }
        public int Weight { get; set; }
        public string Sound { get; set; }

        public Door(string color, int weight): base(color, weight)
        {
            this.Color = color;
            this.Weight = weight;
            this.Sound = "Boooom!";
        }

        public void Explode()
        {
            Console.WriteLine();
            Console.WriteLine(Sound);

        }

    }
}