using System;
namespace MethodOverRiding;
class program
{
   
    public static void Main(string[] args)
    {
         Animal animal=new Animal();
    animal.Eat();

    Dog labrador=new Dog();
    labrador.Eat();

    Pomerian pom=new Pomerian();
    pom.Eat();
    }
}