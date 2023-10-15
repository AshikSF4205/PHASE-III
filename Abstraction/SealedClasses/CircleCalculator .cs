namespace SealedClasses
{
    public class CircleCalculator : Calculator
    {
        public sealed override void Area()
        {
            System.Console.WriteLine("Override Area of Circle");
        }
            
        
        public sealed override void volume()
        {
            System.Console.WriteLine("Override Volume of Circle");
        }





    }
}