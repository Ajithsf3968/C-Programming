using System;
namespace LeapYear;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Input data:");
        int year=int.Parse(Console.ReadLine());
        if((year%4==0) && (year%100!=0 || year%400==0))
        {
            System.Console.WriteLine(year+"is a leap year");
        }
        else
        {
            System.Console.WriteLine(year+"is non leap year");
        }
    }
}
