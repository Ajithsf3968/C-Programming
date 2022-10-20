using System;
namespace ExceptionHandling;
class Program
{
    public static void Main(string[] args)
    {
        int number1,number2;
        try
        {
            System.Console.WriteLine("Enter the first number:");
            number1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the second number");
            number2=int.Parse(Console.ReadLine());
            int result=number1/number2;
            System.Console.WriteLine(result);

        }
        catch(FormatException e)
        {
               System.Console.WriteLine(e.Message);
               System.Console.WriteLine(e.StackTrace);
        }
        catch(DivideByZeroException e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
        }
        finally
        {
            System.Console.WriteLine("All exceptions handled");
        }
       
    }
}