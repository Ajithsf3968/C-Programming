using System;
namespace Hierarchical1;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo person = new PersonalInfo("Ajith","pugal",123445,"asdf@123",new DateTime(2000,10,10),Gender.Male);
        person.ShowDetails();
        Teacher teacher=new Teacher("ravi","hhihu",456876,"ravi@!23",new DateTime(1980,10,10),Gender.Male,TeacherDepartment.EEE,"circuit","BE",10,new DateTime(2020,10,09));
        teacher.ShowTeacherDetails();
        StudentDetails student=new StudentDetails("Ajith","pugal",123,"dzs@12",new DateTime(2020,10,10),Gender.Male,Department.CSE,"2020");
        student.ShowDStudentDetails();
        
    }
}