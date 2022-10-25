using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        int num1,num2,add,sub,mul,div,mod;
        System.Console.WriteLine("enter the first number:");
        num1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("enter the second number:");
        num2=int.Parse(Console.ReadLine());
        add=num1+num2;
        sub=num1-num2;
        mul=num1*num2;
        div=num1/num2;
        mod=num1%num2;
        System.Console.WriteLine("addition:"+add+"\n"+"subtraction:"+sub+"\n"+"multiplication:"+mul+"\n"+"division:"+div+"\n"+"modulo:"+mod);

    }
}