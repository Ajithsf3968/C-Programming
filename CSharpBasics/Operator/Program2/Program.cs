using System;
namespace Program2;
class Program
{
    public static void Main(string[] args)
    {
        //TO find Largest Amoung Three Numbers
        System.Console.Write("Enter a Number: ");
        
        int numberOne=int.Parse(Console.ReadLine());
        System.Console.Write("Enter a Number: ");
         //get the input from the user
        int numberTwo=int.Parse(Console.ReadLine());
        System.Console.Write("Enter a Number: ");
         //get the input from the user
        int numberThree=int.Parse(Console.ReadLine());

        //Check the Number which is Largest among three

        if((numberOne > numberTwo) && (numberOne > numberThree))
        {
            System.Console.WriteLine($"NumberOne is Largest: {numberOne}");
        }
        else if((numberTwo > numberOne)&&(numberTwo > numberThree))
        {
            System.Console.WriteLine($"NumberTwo is Largest: {numberTwo}");
        }
        else
        {
            System.Console.WriteLine($"numberThree is Largest: {numberThree}");
        }
    }
}