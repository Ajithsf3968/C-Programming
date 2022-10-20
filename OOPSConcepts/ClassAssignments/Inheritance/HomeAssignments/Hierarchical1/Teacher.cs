using System;
namespace Hierarchical1
{
    public enum TeacherDepartment{Default,EEE,ECE,CSE}
    public class Teacher:PersonalInfo
    {
        private static int s_teacherID=1000;
        public int TeacherID { get; set; }
        public  TeacherDepartment Department  { get; set; }
        public  string SubjectTeaching { get; set; }
        public string Qualification { get; set; }
        public int Experience{ get; set; }
        public DateTime DateOfJoining{ get; set; }


    
        public Teacher(string name,string fatherName,long phone,string  mailID,DateTime DOB,Gender gender,TeacherDepartment department,string subjectTeaching,string qualification,int experience,DateTime DOJ):base( name, fatherName,phone,mailID,DOB,gender)
        {
           s_teacherID++;
           TeacherID=s_teacherID;
           Department=department;
           SubjectTeaching=subjectTeaching;
           Qualification=qualification;
           Experience=experience;
           DateOfJoining=DOJ;
        }
        public void ShowTeacherDetails()
        {
            System.Console.WriteLine("TeacherID"+TeacherID);
            ShowDetails();
            System.Console.WriteLine(Department);
            System.Console.WriteLine(SubjectTeaching);
            System.Console.WriteLine(Qualification);
            System.Console.WriteLine(Experience);
            System.Console.WriteLine(DateOfJoining);
        }
    }
}