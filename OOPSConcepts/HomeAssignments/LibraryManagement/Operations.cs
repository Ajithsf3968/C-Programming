using System;
using System.Collections.Generic;
namespace LibraryManagement
{
    public static class Operations
    {
        public static void MainMenu()
        {
           System.Console.WriteLine("----Main Menu----");
           System.Console.WriteLine("enter 1.registration \n 2.Login \n 3.Exit");
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
               System.Console.WriteLine("Enter your name:");
               name=Console.ReadLine();
               System.Console.WriteLine("enter gender:");
               Gender=Enum.Parse<Gender>(.Console.WriteLine(),true);
               
          }
        }

    }
}