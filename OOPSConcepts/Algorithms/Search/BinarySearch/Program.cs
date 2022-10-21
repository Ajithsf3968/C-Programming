using System;
namespace BinarySearch;
class Program
{
    public static void Main(string[] args)
    {

        int[] arr={10,20,30,40,50};
        int start=0,end=arr.Length;
        
        System.Console.WriteLine("entet the element:");
        int element=int.Parse(Console.ReadLine());
        for(int i=0;i<arr.Length;i++)
        {
            int mid=(start+end)/2;
            if(element==arr[mid])
            {
                System.Console.WriteLine("element found at:"+mid);
                break;
            }       
            else if(element<arr[mid])
            {
            end=mid-1;
            }
            else if(element>arr[mid])
            {
               start=mid+1;
            }
        }
    }
}