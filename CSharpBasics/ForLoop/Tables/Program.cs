using System;
namespace Tables;
class Program
{
    public static void Main(string[] args)
    {
        int i,n;
        System.Console.WriteLine("Table to be calculated:");
        n=int.Parse(Console.ReadLine());
        for(i=1;i<=10;i++)
        {
            System.Console.WriteLine(i+" "+"X"+" "+n+"="+i*n);
        }
    }
}