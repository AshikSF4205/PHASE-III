namespace PartialClass
{
    public partial class Studentinfo 
    {
        public void Calculate(){
            int total = Physics+Chemistry+Maths;
            System.Console.WriteLine("Total "+total);
            System.Console.WriteLine("Average "+total/3);
        }

        
    }
}