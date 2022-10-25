using System;
namespace Temperature;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter the temperature in centigrade:");
        int temp = int.Parse(Console.ReadLine());
        if(temp<0)
        {
            System.Console.WriteLine("freezing weather");
        }
        else if(temp>=0 && temp<10)
        {
            System.Console.WriteLine("very cold weather");
        }
        else if(temp>=10 && temp <20)
        {
            System.Console.WriteLine("cold weather");
        }
        else if(temp>=20 && temp<30)
        {
            System.Console.WriteLine("normal");
        }
        else if(temp>30 && temp<=40)
        {
            System.Console.WriteLine("its hot");
        }
        else
        {
            System.Console.WriteLine("its very hot");
        }

    }
}