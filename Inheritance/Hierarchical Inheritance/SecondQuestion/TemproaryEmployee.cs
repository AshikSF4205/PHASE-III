using System;

namespace Salary;

class TemproaryEmployeee : Salary
{
     public TemproaryEmployeee(string employeeId, Type employeeType, double totalSalary, double BaseSalary,int Month) 
    : base (BaseSalary,Month)
    {
        EmployeeId = employeeId;
        EmployeeType = employeeType;
        TotalSalary = totalSalary;
        DA = 0.15 * BaseSalary;
        HRA = 0.13 * BaseSalary;

    }

    // EmployeeID, Employee Type, DA=0.2% of basic, HRA= 0.18% of basic, PF – 0.1 % basic, Total Salary
    public string EmployeeId { get; set; }    

    public  Type EmployeeType { get; set; }
    public double TotalSalary { get; set; }

    public double DA { get; set; }
    public double HRA { get; set; }
    public double PF { get; set; }

    public double Basic { get; set; }
    public void Calculate(){
        double show = TotalSalary - Basic+DA+HRA - PF;
         int days = DateTime.DaysInMonth(DateTime.Now.Year,Month);
        System.Console.WriteLine("Your salary is " + (show/365)* days);
    }


    
}