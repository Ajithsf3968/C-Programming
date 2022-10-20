using System;
namespace OperatorOverLoading;
class Program
{
    public static void Main(string[] args)
    {
        Box box1=new Box(1.2,4.5,6.7);
        Box box2=new Box(4.5,2.4,10.8);
        Box box3;
        double volume=0.0;

        volume=box1.CalculateVolume();
        System.Console.WriteLine("Volume of box 1:{0}",volume);
        volume = box2.CalculateVolume();
        System.Console.WriteLine("volume of box 2:{0}",volume);

        box3=box1+box2;
        Box box4=new Box();
        box4=box4.Add(box1,box2);
        volume=box3.CalculateVolume();
        System.Console.WriteLine("volume of box3 :{0}",volume);
        

        
    }
}