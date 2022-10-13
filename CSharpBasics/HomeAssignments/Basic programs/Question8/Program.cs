using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        int a,b,c;
        System.Console.WriteLine("Enter a:");
        a=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter b:");
        b=int.Parse(Console.ReadLine());
        c=a*a+b*b+2*a*b;
        System.Console.WriteLine(c);
        

    }
}