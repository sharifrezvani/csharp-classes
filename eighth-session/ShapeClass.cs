using System;

namespace EightSession

{
    public class Shape
    {
        public int _width { get; set; }
        public int _height { get; set; }
        
        
        


        public Shape(int width, int height)
        {
            this._width = width;
            this._height = height;

        }

        public virtual int CalculateSurface()
        {
            int surface = 0;
            return surface;
        }
    }
}