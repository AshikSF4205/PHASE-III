namespace VirtualClasses
{
    public class Q1
    {
        
    }
    class AreaCalculator{
        public double Radius { get; set; }

        public AreaCalculator(double radius)
        {
            Radius = radius;
        }


        private double Area { get; set; }
        public virtual void Calculate(){
            Area = 3.14 * Radius * Radius;
        }
        public virtual void Display(){
            System.Console.WriteLine(Area);
        }
    }

    class VolumeCalculator:AreaCalculator{
        public VolumeCalculator(double radius,double height)
        :base (radius)
        {
            Height = height;
        }


        public double Height { get; set; }

        private double Volume { get; set; }
        public override void Calculate()
        {
                Volume = 3.14 * Radius * Radius * Height;
        }

        public override void Display()
        {
                System.Console.WriteLine(Volume);
        }

    }
    
}