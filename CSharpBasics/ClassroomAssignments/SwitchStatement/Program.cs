using System;
namespace SwitchStatement;
class Program
{
    public static void Main(string[] args)
    {  
        int num1,num2,num3;
        System.Console.WriteLine("enter  first number:");
        num1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter second number:");
        num2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("enter your choice:\n '+' '-' '*' '/' '%'");
    
        char choice=char.Parse(Console.ReadLine());
        switch(choice)
        {
            case '+':
            {
               num3=num1+num2;
               System.Console.WriteLine("Addition:"+num3);
               break;
            }
            case '-':
            {
                num3=num1-num2;
                System.Console.WriteLine("Subtraction:"+num3);
                break;
            } 
            case '*':
            {
               num3=num1+num2;
                System.Console.WriteLine("multiplication:"+num3);
                break;
            }
             case '/':
            {
                num3=num1/num2;
                System.Console.WriteLine("division:"+num3);
                break;
            }
             case '%':
            {
                num3=num1%num2;
                System.Console.WriteLine("modulas:"+num3);
                break;
            }
            default:
            {
                System.Console.WriteLine("invalid choice");
                break;
            }
            
        }

    }
}