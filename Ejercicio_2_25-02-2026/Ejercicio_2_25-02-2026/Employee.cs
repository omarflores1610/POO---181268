namespace Ejercicio_2_25_02_2026;

public class Employee
{
    public string name;
    public string category;
    public int id;
    public float salary;

    public Employee()
    {
        this.name = Console.ReadLine();
        this.category = Console.ReadLine();
        this.id = int.Parse(Console.ReadLine());
        this.salary = float.Parse(Console.ReadLine());
    }

    public float GetSalary()
    {
        return salary;
    }
}