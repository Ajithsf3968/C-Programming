using System; 
namespace Program3;
class Program 
{
    public static void Main(string[] args)
    {
        Console.Write("Input the value in inches: ");
        double inch = double.Parse(Console.ReadLine());
        double centimeter =  inch * 2.54 ; 
        Console.WriteLine($"The value in Centimeter: {centimeter}");
    }
}
