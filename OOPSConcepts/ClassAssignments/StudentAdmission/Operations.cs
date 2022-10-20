using System;
using System.Collections.Generic;
namespace StudentAdmission
{
   
    
    public static class Operations
    {
    public static List <StudentDetails> studentList=new List <StudentDetails>();
    public static List<DepartmentDetails> departmentList=new List<DepartmentDetails>();
    public static List<AdmissionDetails> admissionList = new List<AdmissionDetails>();
        

        public static void MainMenu()
        {
            string  choice="yes";
            do
            {
                System.Console.WriteLine("Enter your choice \n 1.Registration \n 2.Login \n 3.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("User Registration");
                        UserRegistration();
                        break;
                    }
                    
                    case 2:
                    {
                        UserLogin();
                        System.Console.WriteLine("User login");
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exiting Main Menu");
                        choice="no";
                        break;
                    }
                }
                
            }while(choice=="yes");
            
        }

        public static void UserRegistration()
          {
            System.Console.WriteLine("Enter your name:");
            string studentName=Console.ReadLine();
            System.Console.WriteLine("Enter your Father name");
            string fatherName=Console.ReadLine();
            System.Console.WriteLine("Enter your date date of birth");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter your gender");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your physics mark");
            int physicsMark=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your chemistry mark");
            int chemistryMark=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your maths mark");
            int mathsMark=int.Parse(Console.ReadLine());

            StudentDetails studentObject=new StudentDetails(studentName,fatherName,dob,gender,physicsMark,chemistryMark,mathsMark);
            studentList.Add(studentObject);
            System.Console.WriteLine("Registration successfull");
            System.Console.WriteLine("Your registration ID is:"+studentObject.StudentID);
           
          }

        public static void UserLogin()
        {
            System.Console.WriteLine("enter your Registration ID:");
            string yourID=Console.ReadLine().ToUpper();
            int temp=0;
            StudentDetails member;
            foreach(StudentDetails student in studentList)
            {
                if(yourID==student.StudentID)
                {
                      System.Console.WriteLine("User Found");
                      temp=1;
                      member=student;
                      SubMenu(member);
                      break;
                      
                }

            }
            if(temp==0)
            {
                System.Console.WriteLine("User not found");
                
            }
        }
        public static void SubMenu(StudentDetails member)
        {
            string submenuChoice="yes";
            double cutOff=75.0;
            do
            {
                 System.Console.WriteLine("Sub Menu");
                 System.Console.WriteLine("Enter the option \n 1.CheckEligibility \n 2.Show Details \n 3. Take Admission \n 4.Cancel Admission \n 5. Show admission details \n 6.Exit ");
                 int submenuCondition=int.Parse(Console.ReadLine());
                 switch(submenuCondition)
                 {
                    case 1:
                    {
                        bool result=member.CheckEligibility(cutOff);
                        if(result)
                        {
                            System.Console.WriteLine("you are eligible for admission");
                        }
                        else
                        {
                            System.Console.WriteLine("You are not eligible for admission");
                        }

                        break;
                    }
                    case 2:
                    {
                         ShowDetails(member);
                         break;
                    }
                    case 3:
                    {
                        TakeAdmission(member);
                        break;
                    }
                    case 4:
                    {
                        CancelAdmission(member);
                        break;
                    }
                    case 5:
                    {
                    	ShowAdmissionDetails(member);
                        break;
                    }
                    case 6:
                    {
                        submenuChoice="no";
                        break;
                    }
                 }
            }while(submenuChoice=="yes");
            
        }
       
        public static void ShowDetails(StudentDetails member)
        {
            System.Console.WriteLine("your ID:"+member.StudentID);
            System.Console.WriteLine("student name:"+member.StudentName);
            System.Console.WriteLine("father name:"+member.FatherName);
            System.Console.WriteLine("Date of birth:"+member.DOB);
            System.Console.WriteLine("Gender:"+member.StudentGender);
            System.Console.WriteLine("physics mark:"+member.PhysicsMark);
            System.Console.WriteLine("chemistry mark"+member.ChemistryMark);
            System.Console.WriteLine("Maths mark"+member.MathsMark);
            

        }
        public static void  TakeAdmission(StudentDetails member)
        {
            
           foreach(DepartmentDetails department in departmentList)
           {
               System.Console.WriteLine("Available department "+department.DepartmentID);
               System.Console.WriteLine("Department name"+department.DepartmentName);
               System.Console.WriteLine("Number of seats avilable"+department.NumberOfSeats);
               
           }
        
           System.Console.WriteLine("Enter any department Id:");
           string departmentID=Console.ReadLine().ToUpper();
           int temp=0;
           foreach(DepartmentDetails department in departmentList)
           {
                if (departmentID==department.DepartmentID && department.NumberOfSeats>0)
                {

                    bool result =member.CheckEligibility(75.0);
                    if(result)
                    {
                        System.Console.WriteLine("You are eligible for admission");
                        foreach(AdmissionDetails admission in admissionList)
                        {
                           if(admission.StudentID==member.StudentID && admission.StudentAdmissionStatus==AdmissionStatus.Admitted)
                           {
                              temp=1;
                              System.Console.WriteLine("you have already booked");
                              break;
                           }
                        }
                        if(temp==0)
                        {
                             
                             AdmissionDetails newAdmission=new AdmissionDetails(member.StudentID,department.DepartmentID,DateTime.Now,AdmissionStatus.Admitted);
                             admissionList.Add(newAdmission);
                             System.Console.WriteLine("Admission booked,your admisson id:"+newAdmission.AdmissionID);
                             department.NumberOfSeats--;
                        }



                    }
                    else
                    {
                        System.Console.WriteLine("you are not eligible for admission");
                    }
                   
                }
                
            

           }

            if (temp==0)
            {
                System.Console.WriteLine("Invalid department ID");
            }
          
            
           
           

          

           

             
        }
        public static void  ShowAdmissionDetails(StudentDetails member)
        {
            int temp=0;

            foreach(AdmissionDetails admission in admissionList)
            {
                if(member.StudentID==admission.StudentID)
                {
                    temp=1;
                    System.Console.WriteLine("Admission ID:"+admission.AdmissionID);
                    System.Console.WriteLine("Student ID:"+admission.StudentID);
                    System.Console.WriteLine("Department ID:"+admission.DepartmentID);
                    System.Console.WriteLine("Admission Date:"+admission.AdmissionDate.ToString("dd/MM/yyyy"));
                    System.Console.WriteLine("admission status:"+admission.StudentAdmissionStatus);
                
                }
            }
            if(temp==0)
            {
               System.Console.WriteLine("Still you have not taken any admission");
            }
    }
        public static void CancelAdmission(StudentDetails member)
        {
            int temp=0;
            foreach(AdmissionDetails admission in admissionList)
            {
                if(member.StudentID==admission.StudentID && admission.StudentAdmissionStatus==AdmissionStatus.Admitted)
                {
                     temp=1;
                    admission.StudentAdmissionStatus=AdmissionStatus.Cancelled;
                    foreach(DepartmentDetails department in departmentList)
                    {
                        if(department.DepartmentID==admission.DepartmentID)
                        {
                            department.NumberOfSeats++;
                            System.Console.WriteLine("Admission cancelled");
                        }
                    }
                }


            }
            if(temp==0)
            {
                System.Console.WriteLine("No admission is booked");
            }
        }

    public static void DefaultData()
    {
        StudentDetails studentObject1=new StudentDetails("Ravichandran","Ettaparajan",new DateTime(2001,08,10),Gender.Male,70,80,100);
        StudentDetails studentObject2=new StudentDetails("Baskaran","sethurajan",new DateTime(2000,01,02),Gender.Male,50,90,70);
        

             
        DepartmentDetails departmentObject1=new("EEE",29);
        DepartmentDetails departmentObject2=new("CSE",29);
        DepartmentDetails departmentObject3=new("MECH",30);
        DepartmentDetails departmentObject4=new("ECE",30);

        AdmissionDetails admissionObject1 = new AdmissionDetails(studentObject1.StudentID,departmentObject1.DepartmentID,new DateTime(2020,12,10),AdmissionStatus.Admitted);
        AdmissionDetails admissionObject2 = new AdmissionDetails(studentObject2.StudentID,departmentObject2.DepartmentID,new DateTime(2020,12,11),AdmissionStatus.Admitted);

        studentList.Add(studentObject1);
        studentList.Add(studentObject2);
        departmentList.Add(departmentObject1);
        departmentList.Add(departmentObject2);
        departmentList.Add(departmentObject3);
        departmentList.Add(departmentObject4);
        admissionList.Add(admissionObject1);
        admissionList.Add(admissionObject2);


    }

    }
}