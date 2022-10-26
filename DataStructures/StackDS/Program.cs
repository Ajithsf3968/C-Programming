using System;
namespace StackDS;
class Program
{
    public static void Main(string[] args)
    { 
        Stack<string> myStack1=new Stack<string>(3);
         Stack<int> myStack2=new Stack<int>();
         myStack1.push("one");
         myStack1.push("two");
         myStack1.push("three");
         myStack1.push("four");
         myStack1.Peek();
         myStack1.pop();
         myStack1.Contains("one");

        
    }
}