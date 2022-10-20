using System;
namespace MultilevelInheritence
{
    public class CustomerDetails:PersonalDetails
    {
        private static int s_customerID=1000;
        public string CustomerID { get; set; }
        public double Balance{ get; set; }
        public CustomerDetails(string aid,string name,string fatherName,Gender gender,int phone,double balance):base( aid,name, fatherName, gender, phone)
        {
            s_customerID++;
            CustomerID="CID"+s_customerID;
            Balance=balance;
        }
    }
        


}