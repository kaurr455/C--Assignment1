public class StudentUtilities
{
    public static Student CreateStudent(int id, StudentType type, string firstName, string lastName)
    {
        return new Student
        {
            Id = id,
            Type = type,
            FirstName = firstName ?? "",
            LastName = lastName ?? ""
        };
    }

    public static void OutputStudent(Student student)
    {
        string studentTypeString = student.Type.ToString();
        Console.WriteLine($"Student: {student.Id:D3} {student.FirstName} {student.LastName} ({studentTypeString})");
    }
}