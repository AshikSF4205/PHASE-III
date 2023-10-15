namespace SealedClasses
{
    public class FamilyInfo : PersonalInfo
    {
        public FamilyInfo(string fatherName, string motherName, int noofSibilings, string native,string name,long mobile,Gender gender, string mail)
        : base(name,fatherName,mobile,gender,mail)
        {
            FatherName = fatherName;
            MotherName = motherName;
            NoofSibilings = noofSibilings;
            Native = native;
        }


        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int NoofSibilings { get; set; }
        public string Native { get; set; }

        public sealed override void Update(long number,string mail)        
        {
            Mobile = number;
            Mail  = mail;
        }
        public sealed override void DisplayInfo()
        {
            System.Console.WriteLine("Overrided Method");
        }
    }
}