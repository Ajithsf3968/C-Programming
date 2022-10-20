using System;
namespace Hierarchical1    
{
    
    public enum Department{Default,EEE,ECE,CSE}
    public class StudentDetails:PersonalInfo
    {
        private static int s_studentID=1000;
        public string StudentID { get; set; }
        public Department Department { get; set; }
        public string Year { get; set; }
    
        public StudentDetails(string name,string fatherName,int phone,string mailID,DateTime dob,Gender gender,Department department,string year):base( name,fatherName,phone,mailID,dob,gender)
        {
            s_studentID++;
            StudentID=""+s_studentID;
            Department=department;
            Year=year;
        }
    public void ShowDStudentDetails()
    {

            System.Console.WriteLine("studentID"+StudentID);
            ShowDetails();
            System.Console.WriteLine("Department"+Department);
            System.Console.WriteLine("Year"+Year);

    }  
        
        
        
    
    }
}