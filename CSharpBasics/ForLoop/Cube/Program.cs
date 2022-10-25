using System;
namespace Cube;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the range number");
        int number=int.Parse(Console.ReadLine());
        for(int i=1;i<=number;i++)
        {
            System.Console.WriteLine("Number is "+i+"and the cube of "+i+" "+"is"+i*i*i);

        }
    }
}