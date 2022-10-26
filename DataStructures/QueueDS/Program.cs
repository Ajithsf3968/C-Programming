using System;
namespace QueueDS;
class Program
{
    public static void Main(string[] args)
    {
         Queue<string> myQueue=new Queue <string>();
         myQueue.Enqueue("one");
         myQueue.Enqueue("two");
         myQueue.Enqueue("three");
         myQueue.Enqueue("four");
         System.Console.WriteLine(myQueue.Count);
         System.Console.WriteLine(myQueue.Dequeue());
         System.Console.WriteLine(myQueue.Peek());
        
        System.Console.WriteLine(myQueue.Contains("one"));
         
    }
}