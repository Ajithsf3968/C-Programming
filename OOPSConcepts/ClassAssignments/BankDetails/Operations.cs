using System;
using  System.Collections.Generic;
namespace BankDetails;

    public static class Operations
    {
       public static List<BankProperties> propertiesList = new List<BankProperties>();
       public static void MainMenu()
       {
           

           System.Console.WriteLine("---- main menu----");   
           System.Console.WriteLine("enter choice 1.Registration 2.Login 3.Exit");
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
            String condition=" ";
            do
                
            {

                System.Console.WriteLine("Student Registration form");
                System.Console.WriteLine("Enter your Name: ");
                string name = Console.ReadLine();       
                System.Console.WriteLine("select gender options:Male,Female,Transgender");
                gender Gender=Enum.Parse<gender>(Console.ReadLine(),true);
                System.Console.WriteLine("enter mobile number");
                long phoneNumber=long.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter your Mail Id:");
                string mailId = Console.ReadLine();
                System.Console.WriteLine("Enter date of birth dd/YY/yyyy: ");
                DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                
                BankProperties customerDetails=new BankProperties(name,Gender,phoneNumber,mailId,dob);
                System.Console.WriteLine("your CustomerID:"+customerDetails.CustomerID);
                propertiesList .Add(customerDetails);
                System.Console.WriteLine("Do you want continue yes/no");
                condition=Console.ReadLine().ToLower();
                    
            }while(condition=="yes");
            
           MainMenu();
        }
        public static void Login()
        {
               int temp=0;
            
                System.Console.WriteLine("enter your ID");
                string yourID=Console.ReadLine();
                BankProperties member;
                foreach(BankProperties customer in propertiesList)
                {
                    if(yourID==customer.CustomerID)
                    {
                        temp=1;
                        member=customer;
                        subMenu(member);
                    }
                    else
                    {
                        temp=0;
                    }
                    
                    
                }
            if(temp==0)
            {
                System.Console.WriteLine("Your account is not found");
                MainMenu();
            }
            
                
            
        }
        public static void subMenu(BankProperties member)
        {
            string submenuChoice="";
            do{
            System.Console.WriteLine("----Sub Menu----");
            System.Console.WriteLine("enter choice 1.Deposit \n 2. Withdraw \n 3.Balance check ");
            int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        Deposit(member);
                        break;
                    }
                    case 2:
                    {
                        Withdraw(member);
                        break;
                    }
                    case 3:
                    {
                        Balance(member);
                        break;
                    }
                    case 4:
                    {
                        MainMenu();
                        break;
                    }
                }
                System.Console.WriteLine("Do you want continue yes/no");
                submenuChoice=Console.ReadLine().ToLower();
            }while(submenuChoice=="yes");
            MainMenu();
        }
        public static void Deposit(BankProperties member)
        {
            int deposit;
            System.Console.WriteLine("Enter the amount to be deposit:");
            deposit=int.Parse(Console.ReadLine());
            member.Balance=member.Balance+deposit;
            System.Console.WriteLine("balance amount"+member.Balance);
        }
        public static void Withdraw(BankProperties member)
        {
            int withdraw;
            System.Console.WriteLine("enter the amount to be withdraw");
            withdraw=int.Parse(Console.ReadLine());
            if(withdraw<=member.Balance)
            {
                member.Balance=member.Balance-withdraw;
                System.Console.WriteLine("Amount withdrawed");
                System.Console.WriteLine("balance amount"+member.Balance);

            }
            else
            {
                System.Console.WriteLine("invalid amount");
            }
        }
         public static void Balance(BankProperties member)
         {
            System.Console.WriteLine("balance amount is"+member.Balance);
         }
    
           
    }
