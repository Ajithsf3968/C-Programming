using System;
namespace Transpose;
class Program
{
    public static void Main(string[] args)
    {
        int [,] arr=new int[2,2];
        System.Console.WriteLine("Enter matrix elements");
        for(int i=0;i<2;i++)
        {
            for(int j=0;j<2;j++)
            {
              arr[i,j]=int.Parse(Console.ReadLine());  
            }
        }
        System.Console.WriteLine("The matrix:");
        for(int i=0;i<2;i++)
        {
            for(int j=0;j<2;j++)
            {
             System.Console.Write(arr[i,j]+" ");
            }
            System.Console.WriteLine();
        }
         for(int i=0;i<2;i++)
        {
            for(int j=0;j<2;j++)
            {
              arr[j,i]=arr[i,j];
            }
        }
         System.Console.WriteLine("The transpose of matrix:");
        for(int i=0;i<2;i++)
        {
            for(int j=0;j<2;j++)
            {
             System.Console.Write(arr[i,j]+" ");
            }
            System.Console.WriteLine();
        }

    }
}