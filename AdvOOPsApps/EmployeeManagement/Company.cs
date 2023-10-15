using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Company
    {
        public string EmployeeID { get; set; }

        public string EmploymentID { get; set; }

        public DateTime DateOfRegistration { get; set; }

        public void ShowEmployeeDetail()
        {

        }

        public Company(string employeeID, string employmentID, DateTime dateOfRegistration)
        {
            EmployeeID = employeeID;
            EmploymentID = employmentID;
            DateOfRegistration = dateOfRegistration;
        }

    }
}