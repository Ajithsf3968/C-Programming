using System;
namespace Program1;
class Program
{
public static void Main(string[] args)
{
    System.Console.WriteLine("Enter your name:");
    String name=Console.ReadLine();
    System.Console.WriteLine("Hello"+" "+name);
    System.Console.WriteLine($"Hello {name}");
    System.Console.WriteLine("Hello {0}",name);
}
}