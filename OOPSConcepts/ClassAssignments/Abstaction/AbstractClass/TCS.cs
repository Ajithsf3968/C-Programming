namespace AbstractClass
{
    public class TCS:Employee
    {
         public override string Name{get{return name;} set{name=value;}}
        public override void Salary(int dates)
        {
            display();
            Amount=(double)dates*300;
            System.Console.WriteLine(Amount);
        }
    }
}