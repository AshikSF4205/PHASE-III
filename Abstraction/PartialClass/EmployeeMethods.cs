namespace PartialClass
{
    public partial class EmployeeInfo
    {
        public void Display(){
            System.Console.WriteLine(
                "Name :"+Name+"\nMobile :"+Mobile
            );
        }   
        public void Update(string name,long phone){
            Name = name;
            Mobile = phone;
        }
    }
}