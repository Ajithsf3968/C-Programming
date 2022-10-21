using System;
namespace LinearSearch;
class Program
{
    public static void Main(string[] args)
    {
        int []arr={1,23,45,5,6};
        System.Console.WriteLine("Enter the element to find:");
        int element =int.Parse(Console.ReadLine());
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i]==element)
            {
                System.Console.WriteLine("Element "+" "+element+"is"+"found at "+i);
            }
        }
        System.Console.WriteLine("Element not found");
        
    }
}
