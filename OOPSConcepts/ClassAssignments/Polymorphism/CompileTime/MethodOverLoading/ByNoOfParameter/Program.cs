using System;
namespace ByNoOfParameter;
class Program
{
    //method overloading
    static void Display(int number)
    {
        System.Console.WriteLine("Arguments:"+number);
    }
    static void Display (int number1,int number2)
    {
        System.Console.WriteLine("Argument"+number1+"Argument"+number2);

    }
    public static void Main(string[] args)
    {
        Display(100);
        Display(100,200);
        Console.ReadLine();
        
    }
}