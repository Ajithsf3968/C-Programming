using System;
namespace OddEven;
class Program
{
    public static void Main(string[] args)
    {
        int num;
        System.Console.WriteLine("enter a number:");
        num=int.Parse(Console.ReadLine());
        if(num%2==0)
        {
            System.Console.WriteLine(num+" " + "is an even interger");
        }
        else
        {
            System.Console.WriteLine(num+" " + "is an odd integer");
        }
    }
}