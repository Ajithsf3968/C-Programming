using System;
namespace MultiLevel1
{
    public class HSCDetails:PersonalInfo
    {
       private static int s_hscMarksheetNumber=1000;
       public  int HSCMarksheetNumber { get;  }
       
       

        public int PhysicsMarks { get; set; }
        public int ChemistryMark { get; set; }
        public int Total { get; set; }
        public double Percentage { get; set; }
    
    public HSCDetails(string name,string fatherName,long phone,DateTime DOB,Gender personGender,int physicsMarks,int chemistryMark,int total,int percentage):base(name,fatherName,phone,DOB,personGender)
    {
        s_hscMarksheetNumber++;
        HSCMarksheetNumber=s_hscMarksheetNumber;
        PhysicsMarks=physicsMarks;
        ChemistryMark=chemistryMark;
        Total=total;
        Percentage=percentage;


    }
    public void ShowHSCDetails();
    {
        System.Console.WriteLine("hscMarksheetNumber"+HSCMarksheetNumber);
        ShowDetails();                                                                                                              

    }
        
        
        
        
        
        
        
        
        
    }
}