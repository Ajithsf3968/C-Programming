using System;
namespace Grade;
class Program
{
    public static void Main(string[] args)
    {
        char grade;
        System.Console.WriteLine("enter the grade:'E','V','G','A','F'");
        grade=char.Parse(Console.ReadLine());
        switch(grade)
        {
            case 'E':
            {
                System.Console.WriteLine("Excellent");
                break;
            }
             case 'V':
            {
                System.Console.WriteLine("very good");
                break;
            }
             case 'G':
            {
                System.Console.WriteLine("Good");
                break;
            }
             case 'A':
            {
                System.Console.WriteLine("Average");
                break;
            }
             case 'F':
            {
                System.Console.WriteLine("Fail");
                break;
            }
            default:
            System.Console.WriteLine("invalid");
            break;
        }
    }
}
