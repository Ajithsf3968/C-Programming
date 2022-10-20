using System;
using System.Collections.Generic;

namespace StudentAdmission;
/// <summary>
/// used to process the main menu
/// </summary>
public static class Operations
{   
  public static List<StudentDetails> studentList = new List<StudentDetails>();
    /// <summary>
    /// used to call the different methods
    /// </summary>
  public static void MainMenu()
  {
    DefaultValues();
    System.Console.WriteLine("----main menu----");
    System.Console.WriteLine("enter choice 1. Registration \n 2.Login \n 3.exit ");
    int choice =int.Parse(Console.ReadLine());
    switch(choice)
    {
    case 1:
    {
      Registration();
      break;
    }
    case 2:
    {
      Login();
      break;
    }
    case 3:
    {
      break;
    }
    }
  }
  /// <summary>
  /// used to pass default values for properties
  /// </summary>
  public static void DefaultValues()
  {
    DateTime dob1=new DateTime(12/10/2001);
    StudentDetails defaultUser = new StudentDetails("Ajith","Pugal",dob1,Gender.Male,"ajith@12",40,90,56);
    studentList.Add(defaultUser);

  }
  /// <summary>
  /// used to register the user details
  /// </summary>
  public static void Registration()
  { 
    String condition="";
      do
        
      {
          System.Console.WriteLine("Student Registration form");

          System.Console.WriteLine("Enter your Name: ");
          string name = Console.ReadLine();        
          System.Console.WriteLine("Enter your father's name:");
          string fatherName = Console.ReadLine();
          System.Console.WriteLine("Enter date of birth dd/YY/yyyy: ");
          DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
          System.Console.WriteLine("select gender options:Male,Female,Transgender");
          Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
          System.Console.WriteLine("Enter your Mail Id:");
          string mailId = Console.ReadLine();
          System.Console.WriteLine("Enter your Physics Marks: ");
          int physicsMark=int.Parse(Console.ReadLine());
          System.Console.WriteLine("Enter your Chemistry Marks: ");
          int chemistryMark=int.Parse(Console.ReadLine());        
          System.Console.WriteLine("Enter your Maths Marks: ");  
          int mathsMark=int.Parse(Console.ReadLine());

          StudentDetails student1 = new StudentDetails(name, fatherName,dob,gender,mailId,physicsMark, chemistryMark,mathsMark);
          System.Console.WriteLine("Your Registration succesful Id is: " + student1.RegistrationID);
          studentList.Add(student1);
          System.Console.WriteLine("Do you want continue yes/no");
          condition=Console.ReadLine().ToLower();
            
            
        }while(condition=="yes");
        MainMenu();
  }
  /// <summary>
  /// used to check user id and call sub menu
  /// </summary>
  public static void Login()   
  {
    
        System.Console.WriteLine("Enter your ID");
        string yourID=Console.ReadLine().ToUpper();
        int temp=0;
        foreach(StudentDetails student in studentList)
        {
          if(student.RegistrationID==yourID)
            {
              temp=1;
              System.Console.WriteLine(" you are successfully logged in");
              SubMenu(yourID);
            }
            else
            {
              temp=0;
            }
        }   
        if(temp==0)
        {
          System.Console.WriteLine("your account not found");
          MainMenu();
        }

    } 
    /// <summary>
    /// used to call various submenu 
    /// </summary>
    /// <param name="yourID"></param>
  public static void SubMenu(string yourID)
  {
    System.Console.WriteLine("----sub menu----");
    System.Console.WriteLine("enter option \n1.ShowDetails \n2.CheckEligibility \n 3.Exit");
    int option=int.Parse(Console.ReadLine());
    switch(option)
    {
      case 1:
      {
          ShowDetails(yourID);
          break;
      }
      case 2:
      {
        CheckEligibility(75.0,yourID);
        break;
      }
      case 3:
      {
        MainMenu();
        break;
      
      }
    }
  } 
          
        
        /// <summary>
        /// used to to diplay the student details
        /// </summary>
        /// <param name="yourID"></param> it is used to get the ID from the user
  public static void ShowDetails(string yourID)
  {
    foreach(StudentDetails student in studentList)
    {
      if(student.RegistrationID==yourID)
      {
        System.Console.WriteLine("--------------------------------------------------------------------------------------------------------");
        System.Console.WriteLine($"RegistrationID|Student name|Father name|Date of birth|gender|Mail Id|Physics mark|Chemistry mark|Maths mark|");
        System.Console.WriteLine($"{student.RegistrationID}|{student.StudentName}|{student. FatherName}|{student.DOB.ToString("dd/MM/yyyy")}|{student.StudentGender}|{student.MailID}|{student.PhysicsMark}|{student.ChemistryMark}|{student.MathsMark}");
        System.Console.WriteLine("--------------------------------------------------------------------------------------------------------"); 
        SubMenu(yourID);
      } 
    }
   
    
  }
  /// <summary>
  /// used to check the eligibility of the student
  /// </summary>
  /// <param name="cutoff"></param> it is double type parameter pass cutoff
  /// <param name="yourID"></param>it is used to get the ID from the user
  public static void CheckEligibility(double cutoff,string yourID)
  {
    foreach(StudentDetails student in studentList)
    {
        if(student.RegistrationID==yourID)
        {
          double average=(double)(student.PhysicsMark+student.MathsMark+student.ChemistryMark)/3;
        if(cutoff<average)
        {
          System.Console.WriteLine("You are Eligible for Admission");
        }
        else
        {
          System.Console.WriteLine("You are Not Eligible for Admission");
        }
        SubMenu(yourID);
        }
    }
    

  }

}

 
              

