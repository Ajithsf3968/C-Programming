using System;
namespace OddEven;
class Program
{
  
   public static void Main(string[] args)
   {
     string option="yes";
    do
    {
       System.Console.WriteLine("enter the number");
        int number=int.Parse(Console.ReadLine());
        if(number%2==0)
        {
            System.Console.WriteLine("even number");
        }
        else
        {
            
                System.Console.WriteLine("Odd number");
            
        }
        System.Console.WriteLine("Do you want to continue");
         option=Console.ReadLine();
        
        
    }while(option=="yes");
   }
}