using System;
namespace Program1;
 class Program
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter a first Number: ");
            
        int value1=int.Parse(Console.ReadLine());
        System.Console.Write("Enter a second Number: ");
            
        int value2=int.Parse(Console.ReadLine());
        //Addition
        System.Console.WriteLine("Addition of Two Numbers : "+value1+value2);
        //Subtraction
        System.Console.WriteLine($"Subtraction of Two Numbers  :{value1-value2}");
        //Multiplication
        System.Console.WriteLine($"Multiplication of Two Numbers : {value1 * value2}");
        //Division
        System.Console.WriteLine($"Division of Two Numbers  :{value1/value2}");
        //Modulus
        System.Console.WriteLine($"Modulus of Two Numbers :{value1 % value2}");
    }
}