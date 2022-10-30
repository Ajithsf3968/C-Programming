using System;
namespace Program;
class Program 
{
    public static void Main(string[] args)
    {
        Console.Write("Input the radius of the Circle: ");
        double radius = double.Parse(Console.ReadLine());
        double area = 0, perimeter = 0;
        area = Math.PI * radius * radius ;
        perimeter = 2 * Math.PI * radius ;
        Console.WriteLine($"The Area of the Circle: {area}");
        Console.WriteLine($"The Perimeter of the Circle: {perimeter}");
    }
}