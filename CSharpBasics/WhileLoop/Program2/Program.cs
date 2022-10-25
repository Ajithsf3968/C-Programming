using System;
namespace Program2;
class Program2
{
    public static void Main(string[] args)
    {
        int i=1,sum=0;
        System.Console.WriteLine("enter the count to be squre");
        int count=int.Parse(Console.ReadLine());
        while(i<=count)
        {
            System.Console.Write(i+" ");
            sum=sum+(i*i);
            i++;

        }
        System.Console.WriteLine();
        System.Console.WriteLine(sum);
    }
}