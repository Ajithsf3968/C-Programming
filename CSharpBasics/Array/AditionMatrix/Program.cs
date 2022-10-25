using System;
namespace AditionMatrix;
class Program
{
    public static void Main(string[] args)
    {
     int [,]arr1=new int [2,2];
     int [,]arr2=new int [2,2];
     int [,]arr3=new int [2,2];
     System.Console.WriteLine("Enter elements of first array");
     for(int i=0;i<2;i++)
     {
        for(int j=0;j<2;j++)
        {
            arr1[i,j]=int.Parse(Console.ReadLine());
        }
        
     }
     System.Console.WriteLine("Enter elements of second array");
     for(int i=0;i<2;i++)
     {
        for(int j=0;j<2;j++)
        {
            arr2[i,j]=int.Parse(Console.ReadLine());
        }
     }
     System.Console.WriteLine("The first matrix:");
     for(int i=0;i<2;i++)
     {
        for(int j=0;j<2;j++)
        {
            System.Console.Write(arr1[i,j]+" ");
        }
        System.Console.WriteLine();
        
     }
     System.Console.WriteLine("The second matrix:");
     for(int i=0;i<2;i++)
     {
        for(int j=0;j<2;j++)
        {
            System.Console.Write(arr2[i,j]+" ");
        }
        System.Console.WriteLine();
        
     }
     for(int i=0;i<2;i++)
     {
        for(int j=0;j<2;j++)
        {
            arr3[i,j]=arr1[i,j]+arr2[i,j];
        }
        
     }
     System.Console.WriteLine("The Addition of two  matrix:");
     for(int i=0;i<2;i++)
     {
        for(int j=0;j<2;j++)
        {
            System.Console.Write(arr3[i,j]+" ");
        }
        System.Console.WriteLine();
        
     }



    }
}