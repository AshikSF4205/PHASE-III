using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class PersonalInfo
    {
        /*
        Personal info class:
        Prop: name, father name, mail id, phone
        Methods: UpdateInfo, ShowPersonalDetails
        */

        public string Name { get; set; }

        public string FatherName { get; set; }

        public string MailID { get; set; }

        public long Phone { get; set; }

        public PersonalInfo (string name, string fatherName, string mailID, long phone){

            Name = name;
            FatherName = fatherName;
            MailID = mailID;
            Phone = phone;

        }

        public void UpdateInfo(string uName, string uFatherName, string uMailID, long uPhone ){
            Name = uName;
            FatherName = uFatherName;
            MailID = uMailID;
            Phone = uPhone;
        }

        //to be included in main
        // public void ShowPersonalDetails(){

        // }

        
        
    }
}