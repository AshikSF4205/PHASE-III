namespace SealedClasses
{
    public class DoctorInfo 

    {
        public DoctorInfo(string doctorId, string nameD, string fatherNameF)
        {
            DoctorId = doctorId;
            Name = nameD;
            FatherName = fatherNameF;
        }


        public string DoctorId { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }

        
    }
}