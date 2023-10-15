using System;

namespace FirstQuestion;

class Program {
    public static void Main(string[] args)
    {
        HSCDetails hsc = new HSCDetails("Ashik","Varghese",8080504239,"ashik@gmail.com",DateTime.ParseExact("14/06/2002","dd/MM/yyyy",null),"Male","19CS050","5th","A",2001,"HSC2019",89,45,68);

        hsc.GetMarks();
        hsc.TotalMarks();
        hsc.Percentagee();
        hsc.ShowMarkSheet();

    }
}