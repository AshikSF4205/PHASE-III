namespace PartialClass
{
    public partial class Calculator
    {
        public Calculator(){}   
        public void Addition(int a, int b){
            System.Console.WriteLine("Addition is " + (a+b));
        }
        public void Subraction(int a, int b){
            System.Console.WriteLine("Subraction is " + (a+b));
        }

    }
}