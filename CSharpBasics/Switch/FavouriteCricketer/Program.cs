using System;
namespace FavouriteCricketer;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter your choice:");
        string choice=Console.ReadLine();
        switch(choice)
        {
            case "India":
            {
            System.Console.WriteLine("1.Gambhir \n 2.dhoni \n 3.kohli \n 4.jadeja");
            break;
            }
             case "Pakistan":
            {
            System.Console.WriteLine("1.Hafeez \n 2.Afridi \n 3.UmarGul \n 4.Sarfaraz");
            break;
            }
             case "Bangaladesh":
            {
            System.Console.WriteLine("1.muztafizur \n 2.shakib \n 3.Tamim \n 4.musfiqur");
            break;
            }
            
        }
    }
}