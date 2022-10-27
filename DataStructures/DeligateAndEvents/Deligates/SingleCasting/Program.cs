using System;
namespace SingleCasting;
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
        Calculator nc1=new Calculator(Add);
        Calculator nc2=new Calculator(Multiply);
        //calling method directly
         System.Console.WriteLine("Output:"+Add(10));
        
        System.Console.WriteLine("Output:"+nc1(10));
       System.Console.WriteLine("Output:"+nc2(5));


    }
}