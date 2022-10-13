using System;
namespace StudentDetails;
class program
{
    public static void Main(string[] args)
    {
        int age,mark1,mark2,mark3,total;
        char grade;
        long mobile;
        string name,mailid;
        float avg,cgpa;
        System.Console.WriteLine("enter name:");
        name=Console.ReadLine();
        System.Console.WriteLine("enter age:");
        age=int.Parse(Console.ReadLine());
        System.Console.WriteLine("enter three marks");
        mark1=int.Parse(Console.ReadLine());
        mark2=int.Parse(Console.ReadLine());
        mark3=int.Parse(Console.ReadLine());
        System.Console.WriteLine("enter mobile number");
        mobile=long.Parse(Console.ReadLine());
        System.Console.WriteLine("enter mailid");
        mailid=Console.ReadLine();
        System.Console.WriteLine("enter cgpa");
        cgpa=float.Parse(Console.ReadLine());
        System.Console.WriteLine("enter grade:");
        grade=char.Parse(Console.ReadLine());
        
        total=mark1+mark2+mark3;
        avg=total/3;
        System.Console.WriteLine("Trainee details are:");
        System.Console.WriteLine("Name:"+name);
        System.Console.WriteLine("Age:"+age);
        System.Console.WriteLine("mobile:"+mobile);
        System.Console.WriteLine("mark1:"+mark1);
        System.Console.WriteLine("mark2:"+mark2);
        System.Console.WriteLine("mark3:"+mark3);
        System.Console.WriteLine("total:"+total);
        System.Console.WriteLine("Average"+avg);
        System.Console.WriteLine("Grade:"+grade);
        System.Console.WriteLine("MailId:"+mailid);
        System.Console.WriteLine("CGPA:"+cgpa);





        

        

    }
}