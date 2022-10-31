using System;
namespace EmployeeInfo
{
    public class EmployeeInfo:PersonalInfo
    {
        public string EmployeeID { get; set; }
        public EmployeeInfo(string employeeID,string name,string fatherName,Gender persongender,long phoneNumber):base(name,fatherName,persongender,phoneNumber)
        {
            EmployeeID=employeeID;
        }
        
        public override void Display()
        {
            Console.WriteLine($"EmployeeID :{EmployeeID}");
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"FatherName:{FatherName}");
            Console.WriteLine($"Gender:{PersonGender}");
            Console.WriteLine($"PhoneNumber:{PhoneNumber}");

        }
    }
}