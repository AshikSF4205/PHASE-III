namespace Question2
{
    public abstract class Library
    {
        public Library(){
            Serial_Number++;
            SerialNumber = "LIB"+Serial_Number;
        }
            private int Serial_Number  = 1000;
            public string SerialNumber { get; set; }

            public abstract string Name { get; set; }
            public abstract string BookName { get; set; }
            public abstract string PublisherName { get; set; }
            public abstract int  Year { get; set; }

            public abstract void SetBookInfo();

            public abstract void DisplayInfo();

    }
}