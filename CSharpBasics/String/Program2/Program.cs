using System;
namespace Program2;
class Program 
{
    public static void Main(string[] args)
    {
        Console.Write($"Input the String: ");
        string word = Console.ReadLine();
        int count = 0;
        foreach(char letter in word)
        {
            count++;
        }
        Console.WriteLine($"Length of the String is {count}");
    }
}
