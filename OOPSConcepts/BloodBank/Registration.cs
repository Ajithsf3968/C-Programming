namespace BloodBank
{
    public enum BloodGroup{Default,APositive,BPositive,OPositive,ABPositive}
    public class Registration
    {
        private static int s_donadrID=1000;
        public string DonarID { get; }
        public string DonarName { get; set; }
        public int Age{ get; set; }
        public long MobileNumber { get; set; }
        public BloodGroup Group { get; set; }
        public string NativePlace{ get; set; }
    
     public Registration(string name,int age,long mobile,BloodGroup group,string native)  
     {
        s_donadrID++;
        DonarID="UID"+s_donadrID;
        DonarName=name;
        Age=age;
        MobileNumber=mobile;
        Group=group;
        NativePlace=native;

    
     }

        
        
    }
}