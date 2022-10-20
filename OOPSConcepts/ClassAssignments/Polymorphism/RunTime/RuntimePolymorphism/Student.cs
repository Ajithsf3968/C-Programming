namespace RuntimePolymorphism
{
    public class Student
    {
        public string Name{ get; set; }
        public int TotalMarks{get;set;}
        public virtual void Display(){ }
    }
}