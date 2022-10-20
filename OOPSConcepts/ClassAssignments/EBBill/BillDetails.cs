/// <summary>
/// used to calculate the bill amount
/// </summary>
namespace EBBill;

public class BillDetails
{
    /// <summary>
    ///  auto increamented static field
    /// </summary>
    private static int s_meterID=1000;
    /// <summary>
    /// property MeterID is used to access the field from object
    /// </summary>
    /// <value></value>
    public string MeterID { get; }
    /// <summary>
    /// property user name is to grt and set values from object
    /// </summary>
    /// <value></value>
    public string UserName { get; set; }
    /// <summary>
    /// used to acess the phone number from object
    /// </summary>
    /// <value></value>
    public long PhoneNumber { get; set; }
    /// <summary>
    /// used to acess the Mailid from object
    /// </summary>
    /// <value></value>
    public string MailID { get; set; }
   
    public double UnitsUsed { get; set; }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="userName"></param> is used to get username from the user
    /// <param name="phoneNumber"></param> is used to  get phoneNumber from the user
    /// <param name="mailID"></param> is used to get  mailid from the user
    /// <param name="units"></param> is used to get  units from the user
    public BillDetails(string userName,long phoneNumber,string mailID,double units)
    {
       s_meterID++;
       MeterID="EB"+s_meterID;
       UserName =userName;
       PhoneNumber=phoneNumber;
       MailID=mailID;
       UnitsUsed=units;

    }
    
    
    
    

    
    
    
    
    
    
}
