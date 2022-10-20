using System;
namespace SingleInheritance;
class Program
{
public static void Main(string[] args)
{
    PersonalDetails person=new PersonalDetails("Ajith","Pugal",Gender.Male,189273);
    person.Show();
    StudentDetails student = new StudentDetails("5555","ajith","cvbn",Gender.Male,34567,Department.ECE,"2020");
    student.ShowDetails();
}
} 

