using System;

namespace PartialClass;
class Program
{
    public static void Main(string[] args)
    {
        EmployeeInfo employee =  new EmployeeInfo("UDH","mukesh",new DateTime(2021,12,31),9090808081,Gender.Male);
        employee.Display();
        employee.Update("Kumar",9080069843);
        employee.Display();
        Studentinfo studentinfo = new Studentinfo(new DateTime(2002,01,31),"Mukesh",9080060943,81,80,79);
        studentinfo.Calculate();
        Calculator calculator =  new Calculator();
        calculator.Addition(1,2);
        calculator.Subraction(10,3);
        calculator.Tan(1);
    }
}