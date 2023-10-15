using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Cubes : Shape
    {
        public override double Area { get; set; }
        public override double Volume { get; set; }

        public new double Height { get; set; }

       public Cubes(){

        }
        public Cubes(int height){
            Height = height;
        }

        public override void CalculateArea()
        {
            System.Console.WriteLine("Area of Cube is"+ 6 * Height * Height);
        }
        public override void CalculateVolume()
        {
           System.Console.WriteLine("Volume of Cube is"+ Height * Height * Height);
        }
    }
}