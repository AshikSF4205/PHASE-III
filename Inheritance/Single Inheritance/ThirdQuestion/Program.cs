using System;

namespace ThirdQuestion;

class Program{
    public static void Main(string[] args)
    {
        BookInfo book = new("Fiction", "Philosophy","BID1001","Alchemist","Paul Coehlo",75.00);
        BookInfo book2 = new("Fiction", "Philosophy","BID1002","Alchemist","Paul Coehlo",25.00);
        BookInfo book3 = new("Magical", "Philosophy","BID1003","Alchemist","Paul Coehlo",175.00);
        BookInfo book4 = new("Fiction", "Philosophy","BID1004","Alchemist","Paul Coehlo",375.00);
        ShowDetails(book,book2,book3,book4);

    }

    public static void ShowDetails(BookInfo book,BookInfo book2,BookInfo book3,BookInfo book4)
    {
        System.Console.WriteLine($"Book ID : {book.BookID}");
         System.Console.WriteLine($"Book ID : {book2.BookID}");
          System.Console.WriteLine($"Book ID : {book3.BookID}");
           System.Console.WriteLine($"Book ID : {book4.BookID}");

    }
}