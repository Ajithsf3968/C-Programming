using System;

namespace EmployeeInfo
{
    public class SalaryInfo:EmployeeInfo
    {
        public double NOWD { get; set; }
        public SalaryInfo(string employeeID,string name,string fatherName,Gender persongender,long phoneNumber,double nowd):base(employeeID,name,fatherName,persongender,phoneNumber)
        {
            NOWD=nowd;
        }
        public override void Display()
        {
            base.Display();
            double salary = NOWD*500;
            Console.WriteLine($"Salary:{salary}");
             
        }
    }
}