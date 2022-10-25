using System;
namespace BubbleSort;
class Program
{
    public static void Main(string[] args)
    {
        int []arr=new int[]{27,333,87,5,67};
        int temp=0;
        for(int j=0;j<arr.Length;j++)
        {
       
            for(int i=0;i<arr.Length-1;i++)
            {
                if(arr[i]>arr[i+1])
                {
                    
                    temp=arr[i];
                    arr[i]=arr[i+1];
                    arr[i+1]=temp;
                }
            }
        }
        System.Console.WriteLine("Array after bubble sort:");
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.Write(arr[i]+" ");
        }
    }
}