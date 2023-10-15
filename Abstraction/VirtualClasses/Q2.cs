namespace VirtualClasses
{
    public class Dimension
    {
        public Dimension(double value1, double value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }

        public Dimension(){

        }
        public double value1 { get; set; }
        public double value2 { get; set; }
        public double Area { get; set; }

        public virtual void Calculate(){
            Area = value1*value2;
        }
        public virtual void DisplayArea(){
            System.Console.WriteLine(Area);
        }
    }

    class Rectangle :  Dimension {
        public Rectangle(double length, double height)
        {
            Length = length;
            Height = height;
        }

        public double Area { get; set; }


        public double Length { get; set; }
        public double  Height { get; set; }

        public override void Calculate()
        {
            Area = Length*Height;
        }

        public override void DisplayArea()
        {
                System.Console.WriteLine(Area);
        }
    }

    class Sphere : Dimension{
        public double Radius { get; set; }        
        private double Volume { get; set; }
        Sphere(double radius){
            Radius = radius;
        }

        public override void Calculate()
        {
            Volume = 4*3.14*Radius* Radius;
        }
        public override void DisplayArea()
        {
                System.Console.WriteLine(Volume);
        }
    }



}