using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        int phy,chem,maths,sum;
        double percentage;
        System.Console.WriteLine("enter physics mark:");
        phy=int.Parse(Console.ReadLine());
        System.Console.WriteLine("enter chemistry mark:");
        chem=int.Parse(Console.ReadLine());
        System.Console.WriteLine("enter maths mark:");
        maths=int.Parse(Console.ReadLine());
        sum=phy+chem+maths;
        percentage=(sum/300)*100;
        System.Console.WriteLine("sum="+sum);
        System.Console.WriteLine("percentage="+percentage);
        
    }
}