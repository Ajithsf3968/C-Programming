using System;
namespace BlackTicket
{
    public class UserDetails:PersonalDetails,IWallet
    {
        private double _walletBalance;
        private static int _userID=1000;
        public string UserID { get; }

        public double WalletBalance { get;set; }
        
        
        
        public UserDetails(string name,int age,long phoneNumber,double walletBalance):base( name, age, phoneNumber)
        {
            _userID++;
            UserID="UID"+_userID;   
            _walletBalance=walletBalance;
        }
        public void  RechargeWallet()
        {
          System.Console.WriteLine("Enter the amount to be recharge");
          double rechargeAmount=double.Parse(Console.ReadLine());
          WalletBalance+=rechargeAmount;




        }
        public void DetectBalance(double totalAmount)
        {
           WalletBalance-=totalAmount;
          
        }

        

    }
}