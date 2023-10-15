using System;

namespace SecondQuestion;

class Program {
    public static void Main(string[] args)
    {
        BookInfo book = new BookInfo("CSE","BE",3,5,"BID2003","Book","Author",150);
        book.DisplayInfo();

        BookInfo book2 = new BookInfo("MECH","BE",3,5,"BID2003","Book","Author",150);
        book2.DisplayInfo();
        BookInfo book3 = new BookInfo("ECE","BE",3,5,"BID2003","Book","Author",150);
        book3.DisplayInfo();
    }
}