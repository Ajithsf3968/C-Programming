using System;
namespace AdmissionEligibility;
class Program
{
    public static void Main(string[] args)
    {
        int physicsMark,chemistryMark,mathsMark;
        double percentage;
        System.Console.WriteLine("enter physics mark");
        physicsMark=int.Parse(Console.ReadLine());
        System.Console.WriteLine("enter chemistry mark");
        chemistryMark=int.Parse(Console.ReadLine());
        System.Console.WriteLine("enter maths mark");
        mathsMark=int.Parse(Console.ReadLine());
        percentage=((physicsMark+chemistryMark+mathsMark)/300)*100;
        if(percentage>=75)
        {
            System.Console.WriteLine("the canditate is eligible");
        }
        else
        {
            System.Console.WriteLine("the canditate is not eligible");
        }
    }
}
