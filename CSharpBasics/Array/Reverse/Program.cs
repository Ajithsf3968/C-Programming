using System;
namespace Reverse;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter number elements to be stored in array");
        int count=int.Parse(Console.ReadLine());
        int []arr=new int[count];
        
        System.Console.WriteLine("enter"+count+"numbers");
        
        for(int i=0;i<count;i++)
        {
            int number=int.Parse(Console.ReadLine());
            arr[i]=number;
            
        }
        System.Console.Write("elemets in array: ");
        for(int i=0;i<count;i++)
        {
              System.Console.Write(arr[i]+" ");
            
        }
        System.Console.WriteLine();
        System.Console.WriteLine("elements in reverse order :");
        for(int i=arr.Length-1;i>=0;i--)
        {
              System.Console.Write(arr[i]+" ");
        }

    }
}