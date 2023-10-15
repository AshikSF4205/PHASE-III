using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThirdQuestion
{
    public class BookInfo : DepartmentDetails
    {
        public string BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }

        public BookInfo(string departmentName,string degree,string bookId,string bookName,string authorName,double price) : base (departmentName,degree)
        {
            BookID = bookId;
            BookName = bookName;
            AuthorName = authorName;
            Price = price;
        }
    }
}