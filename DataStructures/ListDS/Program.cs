using System;
namespace ListDS;
class Program
{
    public static void Main(string[] args)
    {
        List<int>numberList=new List<int>(9);
        numberList.Add(10);
        numberList.Add(20);
        numberList.Add(30);
        numberList.Add(40);

        List<int>secondList=new List<int>();
        secondList.Add(10);
        secondList.Add(70);
        secondList.Add(100);
        numberList.AddRange(secondList);

       numberList.Insert(1,100);
       numberList.RemoveAt(1);
       numberList.Remove(30);
       System.Console.WriteLine(numberList.IndexOf(10));
       System.Console.WriteLine(numberList.Contains(20));

       

       foreach(int data in numberList)
       {
        System.Console.WriteLine("Data"+data);
       }

       for(int i=0;i<numberList.Count;i++)
       {
        System.Console.WriteLine(numberList[i]);
       }
    }
}