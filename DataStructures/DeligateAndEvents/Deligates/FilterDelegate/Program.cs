using System;
using System.Collections.Generic;
namespace FilterDelegate;
public delegate bool Filter(Person p);
class program
{
 public static void Main(string[] args)
 {
    Person person1=new Person(){Name="John",Age=41};
    Person person2=new Person(){Name="Jene",Age=69};
    Person person3=new Person(){Name="Jake",Age=12};
    Person person4=new Person(){Name="ravi",Age=10};
    Person person5=new Person(){Name="boss",Age=30};
    Person person6=new Person(){Name="dass",Age=50};
   List <Person> people=new List<Person>(){person1,person2,person3,person4,person5,person6};
   DisplayPeople("Children:",people,IsChild);
    DisplayPeople("Adult:",people,IsAdult);
     DisplayPeople("Senior:",people,IsSenior);
      DisplayPeople("Voter:",people,IsVoter);



 }
 static void DisplayPeople(string title,List<Person> people,Filter filter)
 {
    System.Console.WriteLine("People in "+title+"list are:");
    foreach(Person p in people)
    {
        if(filter(p))
        {
            System.Console.WriteLine("{0},{1}",p.Name,p.Age);
        }
    }
 }
 static bool IsChild(Person p){ return p.Age<15;}
 static bool IsVoter(Person p){ return p.Age>=18;}
 static bool IsAdult(Person p)
{
    if(p.Age>=18 && p.Age<50)
    {
          return true;
    }
    else
    {
       return false;
    }
  
}
static bool IsSenior(Person p){ return p.Age>=50;}
}
 
   
 
