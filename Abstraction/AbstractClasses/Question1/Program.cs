using System;
using Question1;
namespace shape;
class Program
{
   public static void Main(string[] args)
   {
      Shape cube = new Cubes(3);
      Shape shape = new Cylinder(12,10);

      cube.CalculateArea();
      cube.CalculateArea();
   } 
}