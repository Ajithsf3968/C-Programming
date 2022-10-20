using System;
using  System.Collections.Generic;
namespace EBBill;

    /// <summary>
    /// used to acess the mainmenu method
    /// </summary>
    public static class Operations
    {
        public static List<BillDetails> DetailsList=new List<BillDetails>();

        public static void MainMenu()
        {
            
            System.Console.WriteLine("---- main menu ----");
            System.Console.WriteLine("enter the choice:\n 1.Registration \n 2.Login \n 3.exit ");
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
       /// <summary>
       /// used to register ther the user details from the user
       /// </summary>
       public static void Registration()
       {
        string condition="";
            do
            {
                System.Console.WriteLine("enter your name:");
                string name=Console.ReadLine();
                System.Console.WriteLine("enter mobile number:");
                long phoneNumber=long.Parse(Console.ReadLine());
                System.Console.WriteLine("enter your mailID:");
                string mailID=Console.ReadLine();
                System.Console.WriteLine("enter the units used:");
                double units=double.Parse(Console.ReadLine());


                BillDetails Bill=new BillDetails(name,phoneNumber,mailID,units);
                DetailsList.Add(Bill);
                System.Console.WriteLine("your meterID :"+Bill.MeterID);
                System.Console.WriteLine("do you want to continue:yes/no");
                condition=Console.ReadLine().ToLower();
                
            }while(condition=="yes");
            MainMenu();
       }
       /// <summary>
       /// used to login  user id and process the submenu
       /// </summary>
       public static void Login()
       
       {
            int temp=0;
            System.Console.WriteLine("----Login portal----");
            System.Console.WriteLine("enter ID");
            string yourID=Console.ReadLine();
            BillDetails data;
            foreach(BillDetails Detail in DetailsList )
            {
                if(yourID==Detail.MeterID)
                {
                    temp=1;
                    data=Detail;
                    SubMenu(data);
                    
                }
                else
                {
                temp=0;
                }
            }
            if(temp==0)
            {
                System.Console.WriteLine("Invali user ID");
                MainMenu();
            }
       }
       /// <summary>
       /// used to access various functions 
       /// </summary>
       /// <param name="data"></param>
       public static void SubMenu(BillDetails data)
       {
         int option;
         System.Console.WriteLine("enter option \n 1.calculate amount \n 2.Dispaly user details \n3.exit");
         option=int.Parse(Console.ReadLine());
         switch(option)
         {
            case 1:
            {
               CalculateAmount(data);
               break;
            }
            case 2:
            {
                DisplayUserDetails(data);
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
       /// it is used to dispaly the calculateamount
       /// </summary>
       /// <param name="data"></param>
       public static void CalculateAmount(BillDetails data)
       {
        
        double amount=data.UnitsUsed*5;
        System.Console.WriteLine("----------------------------------------------------------");
        System.Console.WriteLine($"|{data.MeterID} | {data.UserName} | {data.UnitsUsed} | {amount}|");
        System.Console.WriteLine("-----------------------------------");
        SubMenu(data);

       }
       /// <summary>
       /// it is used to dipaly the user details
       /// </summary>
       /// <param name="data"></param>
       public static void DisplayUserDetails(BillDetails data)
       {
        System.Console.WriteLine("--------------------------------------------------------------------------");
        System.Console.WriteLine($"|{data.MeterID} | {data.UserName} | {data.PhoneNumber} | {data.MailID}");
        System.Console.WriteLine("--------------------------------------------------------------------------");
        SubMenu(data);
       }
    }
