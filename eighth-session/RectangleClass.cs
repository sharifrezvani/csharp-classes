using System;

namespace EightSession

{
  public class Rectangle: Shape
  {
      public int _surface { get; set; }
      public Rectangle(int width, int height): base(width, height)
      {
          
      }
      

      public override int CalculateSurface()
      {
          _surface = _width * _height;
          return _surface;
      }
  }
}