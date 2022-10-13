using System;
namespace ForLoop;
class Program
{
    public static void Main(string[] args)
    {
        int i,sum=0;
        System.Console.WriteLine("even numbers:");
        for(i=1;i<=25;i++)
        {
            if(i%2==0)
            {
                System.Console.Write(i+" ");
            }
        }
        System.Console.WriteLine();
        System.Console.WriteLine("enter initial value:");
        int initial=int.Parse(Console.ReadLine());
        System.Console.WriteLine("final initial value:");
        int final=int.Parse(Console.ReadLine());
        for(int j=initial;j<=final;j++)
        {
          sum=sum+(j*j);
        }
        System.Console.WriteLine(sum);
        
    }
}