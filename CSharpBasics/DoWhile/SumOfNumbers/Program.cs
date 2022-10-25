using System;
namespace SumOfNumbers;
class Program
{
    public static void Main(string[] args)
    {
        int sum=0,number;
        do
        {
            System.Console.WriteLine("Enter the number");
            number=int.Parse(Console.ReadLine());
            sum=sum + number;
        } while (number>0);
        System.Console.WriteLine("sum is "+sum);
    }
}