using System;

namespace Salary;

class Program
{
    public static void Main(string[] args)
    {
        PermanatEmployee kumar = new PermanatEmployee("001",Type.Permenat,120000,10000,12);
        kumar.Calculate();
        TemproaryEmployeee mukesh = new TemproaryEmployeee("001",Type.Permenat,120000,10000,12);
        mukesh.Calculate();

    }

    
}
class Salary{
    public Salary(double baseSalary, int month)
    {
        BaseSalary = baseSalary;
        Month = month;
    }

    public double BaseSalary { get; set; }
    public int Month { get; set; }
    
    
}