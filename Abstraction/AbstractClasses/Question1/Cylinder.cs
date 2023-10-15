using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Cylinder : Shape
    {
        public override double Area { get; set; }
        public override double Volume { get; set; }

        public new double Height { get; set; }
        public new double Radius {get;set;}
        Cylinder(){

        }
        public Cylinder(double height,double radius){
            Height = height;
            Radius = radius;
        }

        public override void CalculateArea()
        {
           Area = 2 * 3.14 * Radius * (Radius+Height);
            System.Console.WriteLine("Area of Cube is "+Area);
        }
        public override void CalculateVolume()
        {
            Volume = 3.14 * Radius*Radius*Height;
           System.Console.WriteLine("Volume of Cube is "+Volume);
        }
    }
}