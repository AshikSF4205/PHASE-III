namespace PartialClass
{
    public partial class Calculator
    {
        public void sin(double number){
            System.Console.WriteLine("Sin Value is "+ Math.Sin(number));
        }
        public void Cos(double number){
            System.Console.WriteLine("Cos Value is "+ Math.Cos(number));
        }
        public void Tan(double number){
            System.Console.WriteLine("Tan Value is "+ Math.Tan(number));
        }
    }
}