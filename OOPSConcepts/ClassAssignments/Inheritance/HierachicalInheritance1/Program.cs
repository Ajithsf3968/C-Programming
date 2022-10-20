namespace HierachicalInheritance1
{
    public enum Department{Default,EEE,ECE,CSE}
    public class StudentDetails:PersonalDetails
    {
        private static int s_studentID=1000;
        public string StudentID { get; set; }
        public Department Department { get; set; }
        public string Year { get; set; }
    public StudentDetails(string aid,string name,string fatherName,Gender gender,int phone,Department department,string year) :base ( aid, name,fatherName, gender,phone)
    {
        s_studentID++;
        StudentID=aid+s_studentID;
        Department=department;
        Year=year;
    }
    public void  ShowDetails()
    {

            System.Console.WriteLine("studentID"+StudentID);
            Show();
            System.Console.WriteLine("Department"+Department);
            System.Console.WriteLine("Year"+Year);

    }  
        
        
        
        
    }
}