namespace SealedClasses
{
    public enum Gender{Male,Female};
    public class PersonalInfo
    {
        public PersonalInfo(string name, string fatherName, long mobile, Gender gender, string mail)
        {
            Name = name;
            FatherName = fatherName;
            Mobile = mobile;
            Gender = gender;
            Mail = mail;
        }


        public string Name { get; set; }
        public string FatherName { get; set; }
        public long  Mobile { get; set; }
        public Gender Gender { get; set; }
        public string Mail { get; set; }
        
        public void UpdateInfo(){
            
        }
        public virtual void Update(long number,string mail){

        }
        public virtual void DisplayInfo(){

        }
        }
}