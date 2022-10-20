namespace MethodOverRiding
{
    public class Dog:Animal
    {
        public override void Eat()
        {
            System.Console.WriteLine("I am eating dog food");
        }
    }
}