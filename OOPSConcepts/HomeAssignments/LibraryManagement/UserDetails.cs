namespace LibraryManagement
{
    public enum Gender{Default,Male,Female,Transgender}
    public enum Department{ECE,EEE,CSE}
    public class UserDetails
    {
        private static int s_registrationID=3000;
        public string  RegistrationID{ get; set; }
        public string UserName { get; set; }

        public Gender UserGender { get; set; }

        public Department YourDepartment { get; set; }
        public long MobileNumber { get; set; }
        public string MailID {get; set; }
        
     public  UserDetails (string name,Gender gender,Department department,long number,string mailID)
     {
        s_registrationID++;
        RegistrationID="SF"+ s_registrationID;
        UserName=name;
        UserGender=gender;
        YourDepartment=department;
        MobileNumber=number;
        MailID=mailID;

     }
     
     
     
     
     
     
     
     
     
     
        
    }
}