using System;
namespace EmployeeInfo;
class program 
{
    public static void Main(string[] args)
    {
        PersonalInfo person;

        EmployeeInfo employee = new EmployeeInfo("SF3001","Prithis","Iyyappan",Gender.Male,9876543222);
        employee.Display();
        Console.WriteLine($"--------------------------");
        
        SalaryInfo employee1 = new SalaryInfo("SF3001","Prithis","Iyyappan",Gender.Male,9876543222,30);
        employee1.Display();
    }
}
