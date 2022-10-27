using System;
namespace MultiCasting;
public delegate int Calculator(int value);
class Program
{
 static int value=10;
    public static int Add(int number)
    {
        value+=number;
        return value;

    }
    public static int Multiply(int number)
    {
        value*=number;
        return value;
    }
    public static int Getnum()
    {
        return value;
    } 
    public static void Main(string[] args)
    {
        Calculator nc;

        nc=new Calculator(Add);
        nc+=new Calculator(Multiply);
        nc(5);
        System.Console.WriteLine(Getnum());
    }
}