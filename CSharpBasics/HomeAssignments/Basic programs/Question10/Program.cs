using System;
namespace Question10;
class Program
{
    public static void main(string []args)
    {
        int value1=15;
        int value2=20;
        System.Console.WriteLine(value1>value2);
        System.Console.WriteLine(value1<value2);
        System.Console.WriteLine(value1>=value2);
        System.Console.WriteLine(value1==value2);
        System.Console.WriteLine(value1!=value2);
        System.Console.WriteLine(value1<=value2);
        System.Console.WriteLine(value1>=10 && value2>=10);
        System.Console.WriteLine(value1>=10 || value2>=30);
        System.Console.WriteLine(!(value1>20));
        string value = value1==15?"true":"false";
        System.Console.WriteLine(value1++);
        System.Console.WriteLine(value1--);

    }
}