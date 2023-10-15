namespace PartialClass
{
    public partial class Studentinfo 
    {
        

        private static int _id = 100;
        public string ID { get; set; }
        public DateTime DOB { get; set; }
        public string Name { get; set; }
        public long Mobile { get; set; }
        public int Physics { get; set; }
        public int Maths { get; set; }
        public int Chemistry { get; set; }
        
    }
}