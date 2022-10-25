using System;
namespace Question3;
class Program
{
public static void Main(string[] args)
{
    double celsius,kelvin,fahrenheit ;
    System.Console.WriteLine("Enter the amount of celcius:");
    celsius=double.Parse(Console.ReadLine());
    kelvin=celsius+273.15;
    fahrenheit = (celsius * 9/5) + 32;
    System.Console.WriteLine("Kelvin:"+kelvin);
    System.Console.WriteLine("fahrenheit:"+fahrenheit);

}
}