using System;
namespace SingleInheritance1
{
    public enum Branch{Deafault,Biomaths,Commerce,ComputerMaths}
    public class StudentInfo:PersonalInfo
    {
        private static int s_registerNumber=1000;
        public int RegisterNumber { get;  }
        public int Standard { get; set; }
        public string Year { get; set; }
        public Branch StudentBranch { get; set; }
     public StudentInfo(string name,string fatherName,long phone,string  mailID,DateTime DOB,Gender gender,int standard,string year,Branch branch):base(name, fatherName,phone, mailID,DOB,gender)
    {
        s_registerNumber++;
        RegisterNumber=s_registerNumber;
        Standard=standard;
        Year=year;
        StudentBranch=branch;
    }
    public void ShowStudentDetail()
    {
        System.Console.WriteLine(RegisterNumber);
       ShowDetails();
        System.Console.WriteLine("standard"+RegisterNumber+"standard"+Standard+"year"+Year+"studentBranch"+StudentBranch);

    }
    }
   
}