namespace Question2
{
    public class CSEDepartment : Library
    {
        public CSEDepartment(string name, string bookName, string publisherName, int year)
        {
            Name = name;
            BookName = bookName;
            PublisherName = publisherName;
            Year = year;
        }


        public override string Name { get  ; set  ; }
        public override string BookName { get  ; set  ; }
        public override string PublisherName { get  ; set  ; }
        public override int Year { get  ; set  ; }

        public override void DisplayInfo()
        {
           System.Console.WriteLine($"{PublisherName} {Year}"); 
        }

        public override void SetBookInfo()
        {
            System.Console.WriteLine($"{PublisherName} {Year}"); 
        }

    }
}