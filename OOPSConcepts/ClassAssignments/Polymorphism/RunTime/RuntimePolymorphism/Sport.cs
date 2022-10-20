namespace RuntimePolymorphism
{
    public class Sport:Student
    {
        public int SportMark=50;
        public string StudentName { get; set; }
        public override void Display()
        {
            System.Console.WriteLine("Name:"+Name+"mark :"+SportMark);
        }
        
    }
}