using System;
namespace Program;
class Program
{
   public static void Main(string[] args)
   {
    int price;
    double total;
     System.Console.WriteLine("enter the amount of price:");
     price=int.Parse(Console.ReadLine());
     total=price+price*0.18;
     System.Console.WriteLine("total is "+total);

   }
}

