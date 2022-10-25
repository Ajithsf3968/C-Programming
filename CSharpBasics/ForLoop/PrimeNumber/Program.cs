using System;
namespace PrimeNumber;
class Program
{
    public static void Main(string[] args)
    {
        int i,n,temp=0;
        System.Console.WriteLine("enter the number");
        n=int.Parse(Console.ReadLine());
        int m=n/2;
        if(n==0 && n==1)
        {
            System.Console.WriteLine("Given number not prime number");
            temp=1;

        }
        for(i=2;i<=m;i++)
        {
            if(n%i==0)
            {
                 System.Console.WriteLine("Given number not prime number");
                temp=1;
                break;
            }
              
        }
        if(temp==0)
        {
            System.Console.WriteLine("Given number is prime number");
        }
    }
}