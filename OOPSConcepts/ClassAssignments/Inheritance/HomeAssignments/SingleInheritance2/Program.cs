using System;
namespace SingleInheritance2;
class Program
{
    public static void Main(string[] args)
    {
        PersonelInfo person=new PersonelInfo("ajith","pugal",12345,"vgfg@12",new DateTime(2000,10,10),Gender.Male);
        person.ShowDetails();
        AccountInfo account = new AccountInfo("kumar","pugal",123456,"hxhxshx@123",new DateTime(2001,09,09),Gender.Male,765467,"kssnxjs","kvb123",1234);
        account.ShowAccountDetail();
        
    }

}