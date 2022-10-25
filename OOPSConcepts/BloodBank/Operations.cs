using System;
using System.Collections.Generic;
namespace BloodBank;

    public class Operations
    {
         public static List<Registration>registerList=new List<Registration>();
        public static List<Donation>donationList=new List<Donation>();

        public static void MainMenu()
        {
            string choice="yes";
            do{
                System.Console.WriteLine("----Main Menu----");
                System.Console.WriteLine("Enter your option \n 1.UserRegistration \n 2.UserLogin \n 3.Fetch donar details \n4.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                     UserRegistration();
                        break;
                    }
                    case 2:
                    {
                        UserLogin();
                        break;
                    }
                    case 3:
                    {
                        FetchDonarDetails();
                        break;
                    }
                    case 4:
                    {
                        choice="no";
                        break;
                    }
                }
               }while(choice=="yes");
       }
       public static void UserRegistration()
       {
          System.Console.WriteLine("Enter your name:");
          string donarName=Console.ReadLine();
          System.Console.WriteLine("Enter your age");
          int age=int.Parse(Console.ReadLine());
          System.Console.WriteLine("Enter your mobile number");
          long mobile=long.Parse(Console.ReadLine());
          System.Console.WriteLine("Enter your blood group");
          BloodGroup group=Enum.Parse<BloodGroup>(Console.ReadLine(),true);
          System.Console.WriteLine("Enter your native place");
          string native=Console.ReadLine();
          Registration newRegister=new Registration(donarName,age,mobile,group,native);
          System.Console.WriteLine("Registration successfully completed,Your RegistrationID"+newRegister.DonarID);
          registerList.Add(newRegister);
       }
       public static void UserLogin()
       {
        int flag=0;
        System.Console.WriteLine("enter your donar ID");
        string yourID=Console.ReadLine().ToUpper();
        Registration donarData;
        foreach(Registration register in registerList)
        {
            if(yourID==register.DonarID)
            {
               flag=1;
               donarData=register;
               SubMenu(donarData);
               break;
            }
        }
        if(flag==0)
        {
            System.Console.WriteLine("Invalid Donar ID");
        }
       }
       public static void SubMenu(Registration donarData)
       {
          System.Console.WriteLine("----Sub menu----");
          System.Console.WriteLine("choose the choice \n 1.Donate blood \n 2.donation History \n 3.Next eligible date \n 4.Exit");
          int submenuChoice=int.Parse(Console.ReadLine());
          switch(submenuChoice)
          {
            case 1:
            {
               DonateBlood(donarData);
               break;
            }
            case 2:
            {
                DonationHistory(donarData);
                break;
            }
            case 3:
            {
                System.Console.WriteLine("Next eligible date:"+NextEligibleDate(donarData));  
                break;
            }
            case 4:
            {
                break;
            }
          }

       }
       public static void DonateBlood(Registration donarData)
       {
          foreach(Registration register in registerList)
          {
            if(donarData.DonarID==register.DonarID)
            {
                double weight,bp,hpcount;
                System.Console.WriteLine("Enter the weight");
                weight=double.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter your BP level ");
                bp=double.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter your HB count");
                hpcount=double.Parse(Console.ReadLine());
                if((weight>50 && bp<130 && hpcount>13) && (DateTime.Now>NextEligibleDate(donarData)))
                {
                   Donation newdonar=new Donation(donarData.DonarID,DateTime.Now,74,120,14);
                   donationList.Add(newdonar);
                   System.Console.WriteLine("Blood donated successfully,your donation Id"+newdonar.DonationID);
                   System.Console.WriteLine("Next eligible date:"+DateTime.Now.AddDays(60).ToString("dd/MM/yyyy"));
                }
                else{
                    System.Console.WriteLine("you are not eligible to donate blood");
                }

            }
          }
       }
       public static void DonationHistory(Registration donarData)
       {
          foreach(Donation donar in donationList)
          {
            if(donarData.DonarID==donar.DonarID)
            {
                System.Console.WriteLine("-------------------------------------------------------");
                System.Console.WriteLine("| DonationID | DonarId | Donation Date | Weight | Blood Preasure | Hemoglobin count |");
                System.Console.WriteLine($"{donar.DonationID} | {donar.DonarID} | {donar.DonationDate} | {donar.Weight} | {donar.BloodPressure} | {donar.HBCount}");
                System.Console.WriteLine("------------------------------------------------------");
            }
          }
       }
       
       public static DateTime NextEligibleDate(Registration donarData)
       {
           
            DateTime eligibleDate = new DateTime();

            foreach(Donation donar in donationList)
            {
                if(donarData.DonarID==donar.DonarID)
                {
                   
                   eligibleDate=donar.DonationDate.AddDays(60);
                   
                }
            }
            return eligibleDate;
           
       }
       public static void FetchDonarDetails()
       {
        System.Console.WriteLine("Enter your blood group");
        string bloodGroup=Console.ReadLine();
        foreach(Registration register in registerList)
        {
            if(bloodGroup==register.Group.ToString())
            {
                System.Console.WriteLine("-------------------------------------------");
                System.Console.WriteLine("Donar Name | Phone number | Native Place");
                System.Console.WriteLine($"{register.DonarName} | {register.MobileNumber} | {register.NativePlace}");
                System.Console.WriteLine("-------------------------------------------");
            }
        }
       }
       
           
        public static void DefaultValues()
        {
            Registration user1=new Registration(":jhgvc",30,87667,BloodGroup.APositive,"hhbghb");
            Registration user2=new Registration(":baskar",30,877345677,BloodGroup.ABPositive,"TPR");
            registerList.Add(user1);
            registerList.Add(user2);

            Donation donation1=new Donation(user1.DonarID,new DateTime(2022,06,10),73,120,14);
            Donation donation2=new Donation(user1.DonarID,new DateTime(2022,10,10),74,120,14);
            Donation donation3=new Donation(user2.DonarID,new DateTime(2022,07,11),74,120,13.6);
            donationList.Add(donation1);
            donationList.Add(donation2);
            donationList.Add(donation3);

        }
    }

