namespace CafeteriaCardManagement
{
    public enum Gender{Default,Male,Female}
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender PersonGender { get; set; }
        public long  Mobile  { get; set; }
        public string MailID { get; set; }

        public PersonalDetails(string name,string fatherName,Gender personGender,long mobile,string mailID)
        {
              Name=name;
              FatherName=fatherName;
              PersonGender=personGender;
              Mobile=mobile;
              MailID=mailID;
        }
        
        
        
        
        
        
        
        
        
    }
}