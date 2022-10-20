namespace AbstractClass
{
    public abstract class Employee
    {
        protected string name;//normal field
        public abstract string Name {get;set;}
        public double Amount { get; set; }
        public void display()
            {
                 System.Console.WriteLine(name);
            }
        public abstract void Salary  (int dates);
    }
}