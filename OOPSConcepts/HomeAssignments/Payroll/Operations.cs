using System;
/// <summary>
/// for using list
/// </summary>
using  System.Collections.Generic;
namespace Payroll;
/// <summary>
/// used to process the mainmenu
/// </summary>
public static class Operations
    {
      /// <summary>
      /// 
      /// </summary>
      /// <typeparam name="PayrollDetails"></typeparam>
      /// <returns></returns>
       public static List<PayrollDetails> PayrollList= new List<PayrollDetails>();
       /// <summary>
       /// processing mainmenu
       /// </summary>
       public static void  MainMenu()
       {
        System.Console.WriteLine("----Main Menu----");
        System.Console.WriteLine("enter your choice:\n 1.Registration \n 2.Login \n 3.Exit");
        int choice=int.Parse(Console.ReadLine());
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
       public static void Registration()
       {
         string condition="";
         do
         {
            System.Console.WriteLine("enter your name");
            string name=Console.ReadLine();
            System.Console.WriteLine("enter your role:");
            string role=Console.ReadLine();
            System.Console.WriteLine("enter your work location");
            WorkLocation location=Enum.Parse< WorkLocation>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter the team name:");
            string teamName=Console.ReadLine();
            System.Console.WriteLine("Enter enter joining date");
            DateTime  joiningDate=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("enter number of working days");
            int workingDays=int.Parse(Console.ReadLine());
            System.Console.WriteLine("enter number of leaves you take");
            int leaveTaken=int.Parse(Console.ReadLine());
            System.Console.WriteLine("enter gender");
            Gender employeeGender=Enum.Parse< Gender>(Console.ReadLine(),true);

            PayrollDetails Employee=new PayrollDetails(name,role,location,teamName,joiningDate,workingDays,leaveTaken,employeeGender);
            System.Console.WriteLine("Your Employee ID:"+Employee.EmployeeID);
            PayrollList.Add(Employee);
            
            System.Console.WriteLine("do you want to continue yes/no");
            condition = Console.ReadLine().ToLower();
            
         }while(condition=="yes");
         MainMenu();
       }
       public static void Login()
       {
         int temp=0;
         System.Console.WriteLine("----Login portal---");
         System.Console.WriteLine("Enter your ID");
         string YourID=Console.ReadLine();
         foreach(PayrollDetails employee in PayrollList)
         {
            if(YourID==employee.EmployeeID)
            {
               temp=1;
               System.Console.WriteLine("You have successfully logged in");
               SubMenu(YourID);
               break;
            }
            else
            {
               temp=0;
            }
         }
         if(temp==0)
         {
            System.Console.WriteLine("your account is not found ");
            MainMenu();
         }
         
       }
        public static void SubMenu(string YourID)
        {
         System.Console.WriteLine("---- sub menu ----");
         System.Console.WriteLine("Enter option \n 1. Calculate salary \n 2.diplay details \n 3. exit");
         int option=int.Parse(Console.ReadLine());
         switch(option)
         {
            case 1:
            {
               CalculateSalary(YourID);
               break;
            }
            case 2:
            {
               EmployeeDetails(YourID);
               break;
            }
            case 3:
            {
               MainMenu();
               break;
            }
         }

        }
        public static void CalculateSalary(string YourID)
        {
         double salary=0;
          foreach(PayrollDetails employee in PayrollList )
          {
            if(employee.EmployeeID==YourID)
            {
              salary=(30-employee.NumberOfLeaveTaken)*500;
              System.Console.WriteLine("salary is"+salary);
            }
          }
        }
        public static void EmployeeDetails(string YourID)
        {
         foreach(PayrollDetails employee in PayrollList )
          {
            if(employee.EmployeeID==YourID)
            {
               System.Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
               System.Console.WriteLine($"Employee Name |EmployeeID | Role | Employee Work Location | Team Name | Date of joining |  workingDays | leaveTaken | employeeGender");
               System.Console.WriteLine($"{employee.EmployeeName}{employee.EmployeeID} | {employee.Role} | {employee.EmployeeWorkLocation} | {employee.TeamName} | { employee.DateOfJoining} | {employee.NumberOfWorkingDays} | {employee.NumberOfLeaveTaken} | {employee.EmployeeGender}");
               System.Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");

            }
          }
        }
    }
