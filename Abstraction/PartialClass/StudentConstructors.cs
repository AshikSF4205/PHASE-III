namespace PartialClass
{
    public partial class Studentinfo 
    {
        public Studentinfo(DateTime dOB, string name, long mobile, int physics, int maths, int chemistry)
        {
            _id++;
            ID= "SD"+_id;
            DOB = dOB;
            Name = name;
            Mobile = mobile;
            Physics = physics;
            Maths = maths;
            Chemistry = chemistry;
        }
    }
}