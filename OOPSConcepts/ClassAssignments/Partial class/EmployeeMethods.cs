using System;
namespace  PartialClass
{
    public partial class EmployeeMethods
    {
        public EmployeeMethods(int id , string name)
        {
            this.EmpID=id;
            this.Name=name;
        }
        public void DisplayEmpId()
        {
            System.Console.WriteLine("employee Id:"+EmpID);
            System.Console.WriteLine("Name:"+Name);
        }
    }
}