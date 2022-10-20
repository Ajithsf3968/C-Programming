using System;
namespace MethodOverloading
{
    public class Overloading
    {
        public   void Square (int number)
        {
            int result=number*number;
            System.Console.WriteLine("Result is "+result);  

        }
         public  void Square (float number)
        {
          float result=number*number;
            System.Console.WriteLine("Result is "+result);  
                  
        }
         public   void Square (double number)
        {
             double result=number*number;
            System.Console.WriteLine("Result is "+result); 
        }   
        public   void Square (long number)
        {
            long result=number*number;
            System.Console.WriteLine(result);
        }      
        
    }
}
