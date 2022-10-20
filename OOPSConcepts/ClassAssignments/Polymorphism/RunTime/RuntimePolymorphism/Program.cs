using System;
namespace RuntimePolymorphism;
class Program
{
    public static void Main(string[] args)
    {
        Total total=new Total();
        Student student;
        student=total;

        student.Name="Ravi";
        student.Display();

        Sport sport=new Sport();
        student=sport;
        student.Name="chandran";
        student.Display();
}