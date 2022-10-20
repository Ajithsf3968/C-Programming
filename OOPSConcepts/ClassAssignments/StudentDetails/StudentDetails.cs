using System;
/// <summary>
/// Used to process the college admission using this application
/// </summary>
namespace StudentAdmission

{ 
    /// <summary>
    /// used to select 's gender information
    /// </summary>
    public enum Gender{Default,Male,Female,Transgender}
    /// <summary>
    /// Class <see cref ="StudentInfo" />used to collect student's details for admission process
    /// </summary>
    public class StudentDetails
    {
        //field
        /// <summary>
        /// static field used to auto increment and it uniquely identify an instance of 
        /// <see cref="StudentDetails"/>class
        /// </summary>
        
        private static int s_registrationID = 3000;  //Field
        //property
        /// <summary>
        /// Property RegisterNumber used to uniquely identify<see a cref="StudentInfo" /> class's object
        /// </summary>
        
        public string RegistrationID { get;  }  // Property
        public string StudentName { get; set; }    // Auto property
        /// <summary>
        /// 
        /// </summary>
        
        public string FatherName { get;  }
        public DateTime DOB { get; set; }
        /// <summary>
        /// Constructor of <see cref ="StudentInfo"/>class used to initialize values to properties
        /// </summary>
        /// <Param name="name">Parameter name used to initialize a Studenr
        /// <param name="father name">Parameter fatherName used to initialize value to Student's father's name</param>
        /// <param name="studentGender"></param>
         /// <param name="physics"></param>
        /// <param name="chemistry"></param>
        /// /// <param name="dob"></param>
        public Gender StudentGender{ get; set; }
        public string MailID { get; set; }
        public int PhysicsMark { get; set; }
        public int ChemistryMark { get; set; }
        public int MathsMark { get; set; }

        public StudentDetails()
        {
            RegistrationID ="Your ID";
            StudentName="Your name";
            FatherName="Your father name";
            MailID="Your mail ID";

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param> it is used to assigning the user name
        /// <param name="fatherName"></param>it is used to assigning the father name
        /// <param name="dob"></param>it is used to assigning the date of birth
        /// <param name="gender"></param>it is used to assigning the user gender
        /// <param name="mailId"></param>it is used to assigning the usermailid
        /// <param name="physicsMarks"></param>it is used to assigning the user physics marks
        /// <param name="chemistryMarks"></param>it is used to assigning the user chemistry mark
        /// <param name="mathsMarks"></param>it is used to assigning the maths mark
        public StudentDetails(string name, string fatherName, DateTime dob, Gender gender, string mailId, int physicsMarks, int chemistryMarks, int mathsMarks)
        {
            s_registrationID++;

            RegistrationID = "SF"+ s_registrationID;
            StudentName = name;
            FatherName = fatherName;
            DOB= dob;
            StudentGender = gender;
            MailID = mailId;
            PhysicsMark = physicsMarks;
            ChemistryMark = chemistryMarks;
            MathsMark=mathsMarks;
          
        }

        ~StudentDetails()         // Destructor
        {
            System.Console.WriteLine("The destructor called so program closing");
        }


       




        
    }
}