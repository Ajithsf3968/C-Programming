using System;
namespace Program3;

class Program 
{
    public static void Main(string[] args)
    {
        Console.Write($"Input the String: ");
        string word = Console.ReadLine();
        foreach (char letter in word)
        {
            Console.Write($"{letter} ");
        }
        
    }
}
