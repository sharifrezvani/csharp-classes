using System;

namespace TenthSession
{
    public class Phone: Device , IExplode
    {
        public string Color { get; set; }
        public int Weight { get; set; }
        public string Sound { get; set; }


        
        public Phone(string color, int weight): base(color, weight)
        {
            this.Color = color;
            this.Weight = weight;
            this.Sound = "BAAAMMM!";
        }

        public void Explode()
        {
            Console.WriteLine();
            Console.WriteLine(Sound);

        }
        
    }
}