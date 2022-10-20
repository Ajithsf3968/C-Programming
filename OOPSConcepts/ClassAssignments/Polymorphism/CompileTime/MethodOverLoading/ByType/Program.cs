using System;
namespace BYType;
class program
{ 
    static void Display(int number)
    {
        System.Console.WriteLine("int type:"+number);
    }
    static void Display(string name)
    {
        System.Console.WriteLine("string type:"+name);
    }

    public static void Main(string[] args)
    {
        Display(100);
        Display("ajith");
        
    }
}