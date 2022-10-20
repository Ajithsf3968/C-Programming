using System;

namespace EnumTypes{
public enum Gender{DEFAULT,MALE,FEMALE,TRANSGENDER}
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Select gender options Male,Female,Transgender");
        Gender gender1=Enum.Parse<Gender>(Console.ReadLine().ToUpper());
        System.Console.WriteLine(gender1);

         System.Console.WriteLine("Select gender options Male,Female,Transgender");
        Gender gender2=Enum.Parse<Gender>(Console.ReadLine(),true);
        System.Console.WriteLine(gender2);

         System.Console.WriteLine("Select gender options Male,Female,Transgender");
        Gender gender3=Gender.DEFAULT;
        bool temp=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender3);
       while(!temp || !((int)gender3<4 && (int) gender3>0))
       {
        System.Console.WriteLine("Inavlid gender \n");
        temp=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender3);
       }
       System.Console.WriteLine(gender3);
    }
}
}