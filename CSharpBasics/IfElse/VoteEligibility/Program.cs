using System;
namespace VoteEligibility;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Test data:");
        int age=int.Parse(Console.ReadLine());
        if(age>=18)
        {
            System.Console.WriteLine("Congratulation!You are eligible for casting your vote.");
        }
        else
        {
            System.Console.WriteLine("Sorry!You are not eligible for casting your vote.");
        }
        
    }
}