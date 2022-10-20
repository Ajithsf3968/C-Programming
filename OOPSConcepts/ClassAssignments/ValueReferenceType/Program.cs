using System;
namespace ValueReferenceType;
class Program
{
   public static void Main(string[] args)
   {

    // value type
    int number1=10;
    int number2=number1;
    System.Console.WriteLine("number 1 is:"+number1+  "number 2 is:"+number2);
    number2=40;
    System.Console.WriteLine("number 1 is:"+number1+  "number 2 is:"+number2);

    //reference types
    ClassRefer object1;
    object1=new ClassRefer();  //object created
    object1.number=10;
    
    ClassRefer object2=object1; //copying adress of one object to other
    System.Console.WriteLine("number 1:"+object1.number+"number2"+object2.number);

    object2.number=40;

     System.Console.WriteLine("number 1:"+object1.number+"number2"+object2.number);





   }
}
