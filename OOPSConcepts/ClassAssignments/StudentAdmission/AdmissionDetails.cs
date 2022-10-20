using System;
namespace StudentAdmission
{
    public enum AdmissionStatus{Default,Admitted,Cancelled}
    public class AdmissionDetails
    {
        private static int s_admissionId=1000;
        public string AdmissionID { get;  }
        public string StudentID { get; set; }
        public string DepartmentID { get; set; }
        public DateTime AdmissionDate { get; set; }
        public AdmissionStatus StudentAdmissionStatus { get; set; }
         
        
        
        

    public AdmissionDetails(string studentID,string departmentID,DateTime admissionDate,AdmissionStatus admissionStatus)
    {
        s_admissionId++;
        AdmissionID="AID"+s_admissionId;
        StudentID=studentID;
        DepartmentID=departmentID;
        AdmissionDate=admissionDate;
        StudentAdmissionStatus =admissionStatus;
    }
        
        
        
        

        
        
        
        
        
        

    }
}