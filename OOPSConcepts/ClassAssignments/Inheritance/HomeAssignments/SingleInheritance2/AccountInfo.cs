using System;
namespace SingleInheritance2
{
    public enum Branch{Deafault,Biomaths,Commerce,ComputerMaths}
    public class AccountInfo:PersonelInfo
    {
        private static int s_accountNumber=1000;
        public int AccountNumber { get;  }
       
        public string BankBranch { get; set; }
        public string IFSCCOde { get; set; }
        public double Balance { get; set; }
        public string Year { get; set; }
        
     public AccountInfo(string name,string fatherName,long phone,string  mailID,DateTime DOB,Gender gender,int accountNumber,string branch,string IFSCCode,double balance):base(name, fatherName,phone, mailID,DOB,gender)
    {
        s_accountNumber++;
        AccountNumber=s_accountNumber;
        BankBranch=branch;
        IFSCCOde=IFSCCode;
        Balance=balance;
       
       
    }
    public void ShowAccountDetail()
    {
        System.Console.WriteLine(AccountNumber);
       ShowDetails();
        System.Console.WriteLine("BankBranch"+BankBranch+"IFSCCODE"+IFSCCOde+"Year"+Year);

    }
    }
   
}