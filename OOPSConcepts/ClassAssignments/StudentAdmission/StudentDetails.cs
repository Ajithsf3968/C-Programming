using System;
namespace StudentAdmission
{
    public enum Gender{Default,Male,Female,Transgender}
    public class StudentDetails
    {
        private static int s_studentID=3000;
        public string StudentID{ get;  }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public Gender  StudentGender { get; set; }
        
        public int PhysicsMark { get; set; }
        public int ChemistryMark { get; set; }
        public int MathsMark { get; set; }

    public StudentDetails( string studentName,string fatherName,DateTime dob,Gender gender,int physicsMark,int chemistryMark,int mathsMark)
    {
         s_studentID++;
         StudentID="SF"+s_studentID;
         StudentName=studentName;
         FatherName=fatherName;
         DOB=dob;
        StudentGender=gender;
         PhysicsMark=physicsMark;
         ChemistryMark=chemistryMark;
         MathsMark=mathsMark;

    }
    public StudentDetails( string data)
    {
        string[]values=data.Split(',');
        s_studentID=int.Parse(values[0].Remove(0,2));
        StudentID=values[0];
        StudentName =values[1];
        FatherName=values[2];
        DOB=DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
        StudentGender=Enum.Parse<Gender>(values[3]);
        PhysicsMark=int.Parse(values[4]);
        ChemistryMark=int.Parse(values[5]);
    MathsMark=int.Parse(values[6]);
        



    }
    

     public bool CheckEligibility(double cutOff)
        {

            double average=(PhysicsMark+MathsMark+ChemistryMark)/3;
            if(average>=cutOff)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        
        
        
        
        
        
        
        
        
        
        

        
        
        
        
        
        
    }
}