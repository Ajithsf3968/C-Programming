using System;
namespace SelectionSort;
class Program
{
    public static void Main(string[] args)
    {
        int[]arr=new int[5]{10,25,1,45,67};
        int n=5;
       System.Console.WriteLine();
       for(int i=0;i<n;i++)
       {
        System.Console.WriteLine(arr[i]+" ");
       }
       int temp,min;
       for(int i=0;i<n-1;i++)
       {
        min=i;
        for(int j=i+1;j<n;j++)
        {
            if(arr[j]<arr[min])
            {
                min=j;
            }
        }
       
       }
       temp=arr[min];
       arr[min]=arr[i];
       arr[i]=temp;

    }
    System.Console.WriteLine();
    System.Console.WriteLine("Sorted array:");
    for(int i=0;i<n;i++)
    {
        System.Console.WriteLine(arr[i]+" ");
    }
}