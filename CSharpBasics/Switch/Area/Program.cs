using System;
namespace Area;
class Program
{
    public static void Main(string[] args)
    {
        double pi=3.14,area,perimeter;
        System.Console.WriteLine("enter radius");
        double radius=double.Parse(Console.ReadLine());
        System.Console.WriteLine("enter choice");
        int choice=int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
            {
                area=pi*radius*radius;
                System.Console.WriteLine("Area is"+area);
                break;
            }
            case 2:
            {
                perimeter=2*pi*radius;
                System.Console.WriteLine("Perimeter is"+perimeter);
                break;
            }
        }

        
    }
}