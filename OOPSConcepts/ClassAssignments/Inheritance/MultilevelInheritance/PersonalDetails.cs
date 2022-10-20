using System;

namespace MultilevelInheritence
{
    public enum Gender{Default,Male,Female}
    public class PersonalDetails
    {
        private static int s_aID=1000;
        public string AID { get;  }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender PersonGender { get; set; }
        public int Phone { get; set; }
    public PersonalDetails(string name,string fatherName,Gender gender,int phone)
    {
        s_aID++;
        AID="AID"+s_aID;
        Name=name;
        FatherName=fatherName;
        PersonGender=gender;
        Phone=phone;
    }
    public PersonalDetails(string aid,string name,string fatherName,Gender gender,int phone)
    {
        AID=aid;
        Name=name;
        FatherName=fatherName;
        PersonGender=gender;
        Phone=phone;
    }
    
    public void Show()
    {
        System.Console.WriteLine("ID"+AID+"\n Name"+Name+"\n FAtherName"+FatherName+"\nGender"+PersonGender+"\n Phone"+Phone);
    }
        
        
        
        
        
        
        
        
        
        
        
    }
}