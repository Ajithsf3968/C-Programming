using System;
namespace Hierarchical1;

    public enum Gender{Default,Male,Female}
    public class PersonalInfo
    {
        public string Name { get; set; }
        public  string FatherName { get; set; }
        public long Phone { get; set; }
        public string MailID { get; set; }
        public DateTime DateOfBirth{ get; set; }
        public Gender PersonGender { get; set; }
        public PersonalInfo(){

        }
    public PersonalInfo(string name,string fatherName,long phone,string mailID,DateTime DOB,Gender gender)
    {
         Name=name;
         FatherName=fatherName;
         Phone=phone;
         MailID=mailID;
         DateOfBirth=DOB;
         PersonGender=gender;
    }
    public void ShowDetails()
    {
        System.Console.WriteLine("name"+Name+"Father name"+FatherName+"phone"+Phone+"MailId"+"Date of earth"+DateOfBirth);
        

    }
}