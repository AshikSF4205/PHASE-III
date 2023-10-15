using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondQuestion
{
    public class BookInfo : RackInfo
    {

        public string BookId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }

         public BookInfo(string departmentName, string degree, int rackNumber, int columnNumber,string bookId,string bookName,string authorName,double price) : base(departmentName, degree, rackNumber, columnNumber)
        {
            BookId = bookId;
            BookName = bookName;
            AuthorName = authorName;
            Price = price;
        }

        public void DisplayInfo(){
            System.Console.WriteLine($"Department Name : {DepartmentName}\nDegree : {Degree}\nRack Number : {RackNumber}\nColumn Number : {ColumnNumber}\nBook Id : {BookId}\nBook Name : {BookName}\nAuthor Name : {AuthorName}\nPrice : {Price}");
        }
    }
}