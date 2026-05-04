namespace Tarea_Lunes_3;

public class Professor : Person
{
    private string department;
    private int salary;

    public Professor(string newName, string newGender,
        int newAge, string newDepartment,
        int newSalary) : base(newName, newGender, newAge)
    {
        department = newDepartment;
    }

    public string GetDepartment()
    {
        return department;
    }

    public void SetDepartment(string newDepartment)
    {
        department = newDepartment;
    }

    public int GetSalary()
    {
        return salary;
    }
    
    public void SetSalary(int newSalary)
    {
        salary = newSalary;
    }

    public void Teach()
    {
        Console.WriteLine("Soy " + name + " y estoy dando clases en " + department + ".");
    }
}