using System;
using System.IO;
namespace StudentAdmission
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("College"))
            {
                  System.Console.WriteLine("Creating folder");
                  Directory.CreateDirectory("College");
            }
            if(!File.Exists("College/StudentDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("college/studentDetails.csv");
            }
        }
        public static void ReadFile()
        {
            string[] students=File.ReadAllLines("College/Studentdetails.Csv");
            foreach(string data in students)
            {
               StudentDetails student=new StudentDetails(data);
               Operations.studentList.Add(student);

            }
        }
        public static void WriteToFiles()
        {
            string [] StudentDetails = new string[Operations.studentList.Count];
            for(int i=0;i<Operations.studentList.Count;i++)
            {
                StudentDetails[i]=Operations.studentList[i].StudentID+","+Operations.studentList[i].StudentName+","+Operations.studentList[i].FatherName+","+Operations.studentList[i].DOB.ToString("")+","+Operations.studentList[i].StudentGender+","+Operations.studentList[i].PhysicsMark+","+Operations.studentList[i].ChemistryMark+","+Operations.studentList[i].MathsMark+",";
            }
            File.WriteAllLines("College/StudentDetails.Csv",StudentDetails);
        }
    }
}