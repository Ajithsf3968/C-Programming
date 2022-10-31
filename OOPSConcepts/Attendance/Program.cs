using System;
namespace Attendance;
class Program 
{
    public static void Main(string[] args)
    {
        Attendance month1 =new Attendance (26,1,0.5);
        Attendance  month2 =new Attendance(24,0,0);
        Attendance month3 =new Attendance (27,1,1);
        Attendance overall = new Attendance ();
        overall.Add(month1,month2,month3);
        Console.WriteLine($"The Overall salary for 3 months : Rs.{overall.CalculateSalary()}");
        
    }
}


