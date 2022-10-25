using System;
namespace Largest;
class Program
{
    public static void Main(string[] args)
    {
        int num1,num2,num3;
        System.Console.WriteLine("Enter 1st number:");
        num1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter 2nd number:");
        num2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter 3rd number:");
        num3=int.Parse(Console.ReadLine());
        if(num1>num2 && num1>num3)
        {
            System.Console.WriteLine("1st number is the largest");
        }
        else if(num2>num1 && num2>num3)
        {
            System.Console.WriteLine("2nd number is the largest");
        }
        else
        {
            System.Console.WriteLine("3rd number is the largest");
        }

    }
}