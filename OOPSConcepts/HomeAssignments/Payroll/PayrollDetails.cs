using System;
/// <summary>
/// used to  process the payroll details
/// </summary>
namespace Payroll;
/// <summary>
/// used to access the Worklocation
/// </summary>
public enum WorkLocation{Mathura,AnnaNagar,Karura}
/// <summary>
/// used to gender
/// </summary>
public enum Gender{Default,Male,Female,Transgender}
public class PayrollDetails
{
  //field
  /// <summary>
  /// static field used to auto increment and it uniquely identify an instance of 
  /// <see cref="PayrollDetails"/>class
   /// </summary>
    private static int s_employeeID=1000;
        //property
        /// <summary>
        /// Property employeeId used to uniquely identify<see a cref="PayrollDetails" /> class's object
        /// </summary>
    public string EmployeeID { get;  }
    public string EmployeeName { get; set; }

    public string Role{ get; set; }
    public WorkLocation EmployeeWorkLocation { get; set; }
    public  string TeamName { get; set; }
    public DateTime DateOfJoining { get; set; }
    public int NumberOfWorkingDays{ get; set; }
    public int NumberOfLeaveTaken{ get; set; }
    public Gender EmployeeGender{ get; set; }
    /// <summary>
        /// Constructor of <see cref ="PayrollDetails"/>class used to initialize values to properties
        /// </summary>
        /// <Param name="TeamName">Parameter name used to initialize a Studenr
        /// <param name="dateofjoninin">Parameter fatherName used to initialize value to Student's father's name</param>
        /// <param name="workingdays"></param>
         /// <param name="NumberOfLeaveTaken"></param>
        /// <param name="EmployeeGender"></param>
       

public PayrollDetails(string name, string role,WorkLocation location,string teamName,DateTime joiningDate,int workingDays,int leaveTaken,Gender employeeGender)
{
  /// <summary>
  /// field increases
  /// </summary>
  s_employeeID++;
  /// <summary>
  /// initializing EmployeeIxd
  /// </summary>
  EmployeeID="SF"+s_employeeID;
  /// <summary>
  /// initialize Employee name
  /// </summary>
  EmployeeName=name;
  /// <summary>
  /// initializework location
  /// </summary>
  EmployeeWorkLocation=location;
  /// <summary>
  /// initialize teamName
  /// </summary>
  TeamName=teamName;
  /// <summary>
  /// initilaize joining date
  /// </summary>
  DateOfJoining=joiningDate;
  /// <summary>
  /// initialize number of working days
  /// </summary>
  NumberOfWorkingDays=workingDays;
  /// <summary>
  /// initialize number of leaves taken
  /// </summary>
  NumberOfLeaveTaken=leaveTaken;
  /// <summary>
  /// initialize gender
  /// </summary>
  EmployeeGender=employeeGender;

}

}