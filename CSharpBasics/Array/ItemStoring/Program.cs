using System;
namespace ItemStoring;
class Program
{
    public static void Main(string[] args)
    {
        int i;
    int[]arr=new int[10];
    System.Console.WriteLine("enter 10 elements");
    for(i=0;i<arr.Length;i++)
    {
        int element=int.Parse(Console.ReadLine());
        arr[i]=element;
    }
    System.Console.Write("Elements in array are:");
    for(i=0;i<arr.Length;i++)
    {
         System.Console.Write(arr[i]+" ");
    }
    }
} 