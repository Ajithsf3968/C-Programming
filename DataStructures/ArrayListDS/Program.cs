using System;
namespace ArrayListDS;
class Program
{
    public static void Main(string[] args)
    {
        ArrayList myList1=new ArrayList();
        myList1.Add(10);
        myList1.Add("Ajith");
        myList1.Add(10.22);

        ArrayList myList2=new ArrayList();
        myList2.Add(20);
        myList2.Add(40);
        myList2.Add("kumar");
        myList1.AddRange(myList2);

        myList1.Insert(2,100);
        System.Console.WriteLine();
        System.Console.WriteLine( myList1.Contains("Ajith"));
        System.Console.WriteLine();
        myList2.RemoveAt(1);
        System.Console.WriteLine();
        System.Console.WriteLine(myList1.IndexOf(40));
        myList1.Remove(10.22);

        foreach(var data in myList1)
       {
        System.Console.WriteLine("Data"+data);
       }

       
       for(var i=0;i<myList1.Count;i++)
       {
        System.Console.WriteLine(myList1[i]);
       }

    }
}