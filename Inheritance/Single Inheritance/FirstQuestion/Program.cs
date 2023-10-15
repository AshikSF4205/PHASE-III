using System;

namespace FirstQuestion;

class Program {
    public static void Main(string[] args)
    {
        StudentInfo student = new StudentInfo("Ashik","Varghese",9043287870,"ashik@gmail.com",DateTime.ParseExact("14/06/2002","dd/MM/yyyy",null),"Male","19CS050","7th","A",2001);
        StudentInfo studentDefault = new StudentInfo();
        student.Branch = "";
        Console.WriteLine(studentDefault.Branch);
        Console.WriteLine(student.Branch);
    }
}