using System;
using System.IO;
namespace BlackTicket
{
    public class Files
    {
         public static void Create()
        {
            if(!Directory.Exists("Ticket"))
            {
                  System.Console.WriteLine("Creating folder");
                  Directory.CreateDirectory("Ticket");
            }
            if(!File.Exists("Ticket/PersonalDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("Ticket/PersonalDetails.csv");
            }
        }
    }
}