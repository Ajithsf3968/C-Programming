using System;
namespace MultiLevel1
{
    public enum Gender {Default,Male,Female}
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Phone{ get; set; }
        public DateTime DateOfBirth{ get; set; }
        public Gender PersonGender { get; set; }
        
        
    
    public PersonalInfo(string name,string fatherName,long phone,DateTime DOB,Gender personGender)
    {
        Name=name;
        FatherName=FatherName;
        Phone=phone;
        DateOfBirth=DOB;
        PersonGender=personGender;
    }
    public void ShowDetails()
    {
        System.Console.WriteLine();
    }
    }
}