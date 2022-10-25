using System;
namespace Months;
class Program
{
    System.Console.WriteLine("enter  1 For january \n 2. for february \n 3 for march \n 4 for april \n 5 for may \n 6 for june  \n 7 for july \n 8 for August \n 9 for september \n 10 october \n 11 for november \n 12 for december ");
    int choice=int.Parse(Console.ReadLine());
    switch(choice)
    {
        case 1:
        {
            System.Console.WriteLine("Month have 31 days");
            break;
        }

         case 2:
        {
            System.Console.WriteLine("Month have 28 days");
            break;
        }

         case 3:
        {
            System.Console.WriteLine("Month have 31 days");
            break;
        }

         case 4:
        {
            System.Console.WriteLine("Month have 30 days");
            break;
        }

         case 5:
        {
            System.Console.WriteLine("Month have 31 days");
            break;
        }

         case 6:
        {
            System.Console.WriteLine("Month have 30 days");
            break;
        }

         case 7:
        {
            System.Console.WriteLine("Month have 31 days");
            break;
        }

         case 8:
        {
            System.Console.WriteLine("Month have 31 days");
            break;
        }

         case 9:
        {
            System.Console.WriteLine("Month have 30 days");
            break;
        }

         case 10:
        {
            System.Console.WriteLine("Month have 31 days");
            break;
        }

         case 11:
        {
            System.Console.WriteLine("Month have 30 days");
            break;
        }

         case 12:
        {
            System.Console.WriteLine("Month have 31 days");
            break;
        }

         case 1:
        {
            System.Console.WriteLine("Invalid choice");
            break;
        }


    }
    
}