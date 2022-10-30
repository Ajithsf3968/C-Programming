using System;
namespace Program1;
class Program1{
     public static void Main(string[] args)
    {
        Console.Write($"Input 1: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write($"Input 2: ");
        int number2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Addition: {Addition(number1,number2)}");
        Console.WriteLine($"Subtraction: {Subtraction(number1,number2)}");
        Console.WriteLine($"Multiplication: {Multiplication(number1,number2)}");
        Console.WriteLine($"Division: {Division(number1,number2)}");

        int Addition(int number1,int number2)
        {
            return number1 + number2;
        }
        int Subtraction(int number1,int number2)
        {
            return number1 - number2;
        }
        int Multiplication(int number1,int number2)
        {
            return number1 * number2;
        }
        double Division(int number1,int number2)
        {
            return (double) number1 / number2;
        }
    }
}