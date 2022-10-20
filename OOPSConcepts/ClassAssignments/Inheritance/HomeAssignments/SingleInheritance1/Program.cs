using System;
namespace SingleInheritance1;

    class Program
    {
        public static void Main(string[] args)
        {
            PersonalInfo person = new PersonalInfo("ajith","pugal",45678,"Mail ID",new DateTime(2000,10,10),Gender.Male);
           person.ShowDetails();
           StudentInfo student = new StudentInfo("ajith","pugal",56789,"nksn@23",new DateTime(2000,10,10),Gender.Male,12,"2020",Branch.Biomaths);
           student.ShowStudentDetail();

        }
    }
