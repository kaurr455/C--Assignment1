class Program
{
    static void Main(string[] args)
    {
        var student1 = StudentUtilities.CreateStudent(1, StudentType.FullTime, "Ramanpreet", "Kaur");
        var student2 = StudentUtilities.CreateStudent(2, StudentType.PartTime, "Sam", "Wilson");
        var student3 = StudentUtilities.CreateStudent(0, StudentType.PartTime, "Reed", "Richard");

        Console.WriteLine("Alignment One");
        StudentUtilities.OutputStudent(student1);
        StudentUtilities.OutputStudent(student2);
        StudentUtilities.OutputStudent(student3);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}