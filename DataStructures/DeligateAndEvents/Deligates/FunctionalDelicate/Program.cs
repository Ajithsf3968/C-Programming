using System;
namespace FunctionalDelicate;
class Program
{
    static double sum(int number1,int number2)
    {
        return number1+number2;
    }
    static double subtract(int number1,int number2)
    {
        return number1-number2;
    }
    static double Calculator(Func<int,int,double>operation,int x,int y)
    {
        return operation(x,y);
    }
    public static void Main(string[] args)
    {
        System.Console.WriteLine(Calculator(sum,10,20));
        System.Console.WriteLine(Calculator(subtract,20,10));

    }
}