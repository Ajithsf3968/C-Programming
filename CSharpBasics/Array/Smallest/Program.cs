using System;
namespace Smallest;
class Program
{
    public static void Main(string[] args)
    {
        int sum=0;
        System.Console.WriteLine("Enter number elements to be stored in array");
        int count=int.Parse(Console.ReadLine());
        int []arr=new int[count];
         System.Console.WriteLine("enter"+count+"numbers");
        
        for(int i=0;i<arr.Length;i++)
        {
            int number=int.Parse(Console.ReadLine());
            arr[i]=number;
            
        }
        System.Console.Write("elemets in array: ");
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.Write(arr[i]+" ");
        }
        for(int i=0;i<arr.Length;i++)
        {
              sum=sum+arr[i];
            
        }
        System.Console.WriteLine();
        System.Console.WriteLine("sum: "+sum);

    }
}