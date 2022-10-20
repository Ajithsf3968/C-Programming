
namespace StaticElements
{
    public static class StudentInfo
    {
        public static int RegisterNumber;
        public static string Name { get; set; }
        
        
        static StudentInfo()
        {
            RegisterNumber =1;
            Name="Ravi";
        }

        public static void Display()
        {
            System.Console.WriteLine("Register Number"+RegisterNumber);
            System.Console.WriteLine("Name"+Name);
        }
        
    }
}