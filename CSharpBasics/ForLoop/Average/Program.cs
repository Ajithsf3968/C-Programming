using System;
namespace Average;
class Program
{
    public static void Main(string[] args)
    {
        int i,sum=0;
        double average;
        for(i=1;i<11;i++)
        {
            int number=int.Parse(Console.ReadLine());
            System.Console.WriteLine();
            sum=sum+number;
        }
        average=sum/10;
        System.Console.WriteLine("sum"+sum);
        System.Console.WriteLine("Average"+average);
    }

}
