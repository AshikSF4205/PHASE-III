namespace SealedClasses
{
    public sealed class PatientInfo : DoctorInfo
    {
        public PatientInfo(string patientId, string name, string fatherName, int bedNo, string nativePlace, string admittedFor,string doctorId, string nameD, string fatherNameF)
        : base(doctorId,nameD,fatherNameF)
        {
            PatientId = patientId;
            Name = name;
            FatherName = fatherName;
            BedNo = bedNo;
            NativePlace = nativePlace;
            AdmittedFor = admittedFor;
        }


        public string PatientId { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public int BedNo { get; set; }
        public string NativePlace { get; set; }
        public string AdmittedFor { get; set; }

        public void DisplayInfo(){

        }
        
    }
}