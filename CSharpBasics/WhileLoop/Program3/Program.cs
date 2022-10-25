using System;
namespace Program3;
class Program
{
    public static void Main(string[] args)
    {
        int i=2,num1=0,num2=1,num3;
        System.Console.Write(num1+" "+num2+" ");
        while(i<10)
        {
             num3=num1+num2;
             num1=num2;
             num2=num3;
             System.Console.Write(num3+" ");
             i++;
        }
    }
}
