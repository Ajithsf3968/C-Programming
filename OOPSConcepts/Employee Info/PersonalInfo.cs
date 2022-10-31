namespace EmployeeInfo
{
    
        public enum Gender{Default,Male,Female}
    public abstract class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender PersonGender { get; set; }
        public long PhoneNumber { get; set; }
        public PersonalInfo(string name,string fatherName,Gender persongender,long phoneNumber)
        {
            Name=name;
            FatherName=fatherName;
            PersonGender=persongender;
            PhoneNumber=phoneNumber;
        }
        public abstract void Display();
    }
    
}