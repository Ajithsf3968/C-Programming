using System;
namespace Question4;
class program{
public static void Main(string[] args)
{
    double volume,r,h;
    System.Console.WriteLine("enter radius:");
    r=double.Parse(Console.ReadLine());
    System.Console.WriteLine("enter height:");
    h=double.Parse(Console.ReadLine());
    volume=3.14*r*r*h;
    System.Console.WriteLine("volume is:"+volume);
}
}