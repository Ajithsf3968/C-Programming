namespace CafeteriaCardManagement
{
    public class UserDetails:PersonalDetails,IBalance
    {
       private static double s_walletBalance;
       private static int s_userID=1000;
       public string UserID { get;  }
         public double WalletBalance { get;set; }
       
       
       public string WorkStationNumber { get; set; }

    public UserDetails(string name,string fatherName,Gender personGender,long mobile,string mailID,double walletBalance,string stationNumber):base(name,fatherName,personGender,mobile,mailID)
    {
        s_userID++;
        UserID="UID"+s_userID;;
        WalletBalance=walletBalance;
 
    }
    public void WalletRecharge()
    {

    }
       
       

        
        
        
    }
}