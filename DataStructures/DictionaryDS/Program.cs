using System;
namespace DictionaryDS;
class Program
{
    public static void Main(string[] args)
    {
        Dictionary<long,string> phone=new Dictionary<long, string>();
        phone.Add(12345678,"ravi");
        phone.Add(98765432,"baskar");
        phone.Add(746553,"Ajith");
        phone.Add(746553,"jxjx");
        System.Console.WriteLine(phone.ContainsKey(74553));
        System.Console.WriteLine(phone[12345678]);
        foreach(KeyValuePair<long,string> data in phone)
        {
            System.Console.WriteLine("key is"+data.Key+"value is"+data.Value);
        }
        phone[12345678]="mani";
    
    }
}