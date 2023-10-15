namespace Abstract_Methods
{
    public enum Engine{Petrol,Diesal,cng};
    public enum CarType{Hatchback,sedan,suv};
    public abstract class Car
    {
        private int _NoofDoors = 4;
        private int _NoofWheels = 4;    
        public Car(){}
        public Engine Type { get; set; }
        public  int NoofSeats { get; set; }
        public CarType MyProperty { get; set; }

        public void ShowWheels(){
            System.Console.WriteLine(_NoofDoors);
        }
        
        public void ShowDoors(){
            System.Console.WriteLine(_NoofWheels);
        }        

        public abstract void GetEngine();
        public abstract void GetSeats();
        public abstract void GetPrice();
        public abstract void Display();


    }


     class MaruthiSwift : Car{
        public MaruthiSwift(){}
        public Engine Type { get; set; }
        public  int NoofSeats { get; set; }
        public CarType MyProperty { get; set; }

        
        
        public override void Display()
        {
           System.Console.WriteLine("Maruthi...");
        }

        public override void GetEngine()
        {
            Console.WriteLine();
        }

        public override void GetPrice()
        {
           
        }

        public override void GetSeats()
        {
           
        }
    }
}