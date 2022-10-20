using System;
using System.Collections.Generic;
namespace StudentAdmission;
class Program
{
    public static void Main(string[] args)
    {
        Files.Create();
        Files.ReadFile();
        //Operations.DefaultData();
        Operations.MainMenu();
        Files.WriteToFiles();
    }
}