using System;
namespace WholeNumber;
class Program
{
    public static void Main(string[] args)
    {
        int i=0;
        System.Console.WriteLine("Enter the number last number");
        int n=int.Parse(Console.ReadLine());
        while(i<=n)
        {
            System.Console.Write(i+" ");
            i++;
        }
    }
}