using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondQuestion
{
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }

        public string Gender { get; set; }


        public PersonalInfo(string name,string fatherName,long phoneNumber,string email,DateTime date,string gender)
        {
            Name = name;
            FatherName = fatherName;
            PhoneNumber = phoneNumber;
            Email = email;
            Date = date;
            Gender = gender;
        }
    }
}