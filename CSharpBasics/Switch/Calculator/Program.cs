using System;
namespace Calculator;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first integer:");
        int integer1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the second integer:");
        int integer2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("enter your choice\n 1-Addition \n 2-subtraction \n 3-multiplication \n 4-Division \n 5-Exit");
        int choice=int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
            {
                 System.Console.WriteLine("the addition of "+integer1+"and"+integer2+"is"+(integer1+integer2));
                 break;
            }
            case 2:
            {
                 System.Console.WriteLine("the subtraction  of "+integer1+"and"+integer2+"is"+(integer1-integer2));
                 break;
            }
            case 3:
            {
                 System.Console.WriteLine("the multiplication of "+integer1+"and"+integer2+"is"+(integer1*integer2));
                 break;
            }
              case 4:
            {
                 System.Console.WriteLine("the division of "+integer1+"and"+integer2+"is"+(integer1/integer2));
                 break;
            }
            case 5:
            {
                break;
            }
        }
    }
}