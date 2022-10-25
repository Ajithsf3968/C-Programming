using System;
namespace BloodBank
{
    public class Donation
    {
        private static int s_donationID=1000;
        public string DonationID { get;  }
        public string DonarID{ get; set; }
        public DateTime DonationDate{ get; set; }
        public double Weight { get; set; }
        public double BloodPressure{ get; set; }
        public double HBCount { get; set; }
    public Donation(string donarID,DateTime donationDate,double weight,double BP,double hbCount)
    {
       s_donationID++;
       DonationID="DID"+s_donationID;
       DonarID=donarID;
       DonationDate=donationDate;
       Weight=weight;
       BloodPressure=BP;
       HBCount=hbCount;
    }
        
        
        
        
        
        
        
        
        
        
        
        
    }
}