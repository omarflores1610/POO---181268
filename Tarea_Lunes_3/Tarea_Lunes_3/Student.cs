namespace Tarea_Lunes_3;

public class Student : Person
{
    private string major;
    private int currentSemester;
    public Student(
        string newName,
        string newGender,
        int newAge,
        string newMajor,
        int newSemester
    ) : base(newName, newGender, newAge)
    {
        major = newMajor;
        currentSemester = newSemester;
    }
    public void AttendClass()
    {
        Console.WriteLine("I am attending to a class int the " + major + " major.");
    }
    public void DoHomework()
    {
        Console.WriteLine("I am doing homework.");
    }
}