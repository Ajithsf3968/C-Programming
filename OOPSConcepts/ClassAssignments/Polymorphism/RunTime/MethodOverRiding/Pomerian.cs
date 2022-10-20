namespace MethodOverRiding
{
    public class Pomerian
    {
        public new void Eat()  //sealing overriding method
        {
            System.Console.WriteLine("I am eating pomerian dog food");
        }
    }
}