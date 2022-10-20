using System;
namespace SingleInheritance2
{
    public enum Gender{Default,Male,Female}
    public class PersonelInfo
    {
        public  string Name { get; set; }
        public string FatherName { get; set; }
        public long Phone{ get; set; }
        public string MailID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender UserGender { get; set; }

    public PersonelInfo(string name,string fatherName,long phone,string mailID,DateTime dob,Gender gender)
    {
        Name=name;
        FatherName=fatherName;
        Phone=phone;
        mailID=MailID;
        DateOfBirth=dob;
        UserGender=gender;

    }
    public void ShowDetails()
    {
        System.Console.WriteLine("name"+Name+"Father name"+FatherName+"phone"+Phone+"mailid"+MailID+"dob"+DateOfBirth+"gender"+UserGender);
    }
    }
}