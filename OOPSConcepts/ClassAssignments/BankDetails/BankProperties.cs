using System;
namespace BankDetails
{
    public enum gender{Default,Male,Female,Transgender}
    public class BankProperties
    {
        private static int s_customerID=1000;
        public string CustomerID { get; }
        public string CustomerName { get; set; }
        public double Balance { get; set; }
        public gender Gender { get; set; }
        public long PhoneNumber { get; set; }
        public string MailID{ get; set; }
        public DateTime DOB { get; set; }

        public BankProperties()
        {
          CustomerName = "Ajith"; 
          MailID="ajith@21";
        }
        public BankProperties(string name,gender Gender,long phoneNumber,string mailId,DateTime dob)
        {
           s_customerID++; 
           CustomerID="HDFC"+s_customerID;
           CustomerName = name; 
           PhoneNumber=phoneNumber;
           MailID=mailId;
           DOB=dob;
        }
     }
}