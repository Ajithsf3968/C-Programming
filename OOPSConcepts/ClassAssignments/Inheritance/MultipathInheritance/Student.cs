namespace MultipathInheritance
{
    class Student:ISport,IAcadamic
    {
        public int AcadamicMark{get;set;}
        public string Name { get; set; }
        public int SportMark{ get; set; }
        public int MyProperty { get; set; }
    public Student(string name,int academicMark,int sportMark)
    {
        Name=name; AcadamicMark=academicMark ; SportMark=sportMark;
    }
    public void Display()
    {
        System.Console.WriteLine("Name"+Name+"Total Mark"+(Name+AcademicMark)"");
    }

    }
}