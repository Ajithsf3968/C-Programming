namespace RuntimePolymorphism
{
    public class Total
    {
        public int TotalMarks;
        public int AcademicMark=50;
        public override Display()
        {
              TotalMarks=AcademicMark+SportMark;
        }
    }
}