using System;
namespace MethodOverloading;
class program
{
    public static void Main(string[] args)
    {
        Overloading over = new Overloading();
        over.Square(4);
        over.Square(5.2);
        over.Square(5.3);
        over.Square(123456);


    }
}