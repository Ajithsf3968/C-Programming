using System;
namespace MultiLevel1
{
    public class StudentInfo:PersonalInfo
    {
        public static int s_register  { get; set; }
        public int Register { get;  }
        public int Standard  { get; set; }
        public string Branch { get; set; }
        public string Year { get; set; }

    public StudentInfo(string name,string fatherName,long phone,DateTime DOB,Gender personGender,int standard,string branch,string year):base(name,fatherName,phone,DOB,personGender)
    {
        s_register++;
        Register=s_register;
        Standard=standard;
        Branch=branch;
        Year=year;
    }
        
   }
}