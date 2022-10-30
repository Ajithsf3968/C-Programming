using System;
namespace Program1;
class Program
{
    public static void Main(string[] args)
    {
       System.Console.WriteLine("Enter a Grade: ");
       //Get the input from the User
       char input=char.Parse(Console.ReadLine().ToUpper());
      
       if(input=='A')
       {
        System.Console.WriteLine("Grade A denotes 9 Points");
       }
       else if(input=='B')
       {
        System.Console.WriteLine("Grade B denotes 8 Points");
       }
       else if(input=='C')
       {
        System.Console.WriteLine("Grade C denotes 7 Points");
       }
       else if(input=='D')
       {
        System.Console.WriteLine("Grade D denotes 6 Points");
       }
       else
       {
        System.Console.WriteLine("This is not valid Grade");
       }

    }
}
