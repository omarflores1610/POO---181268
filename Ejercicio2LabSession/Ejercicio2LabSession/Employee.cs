namespace Ejercicio2LabSession;

public class Employee
{
    public string name;
    public string category;
    public int id;
    public float salary;

    public Employee()
    {
        Console.WriteLine("Ingresa el nombre del empleado: ");
        name = Console.ReadLine();
        Console.WriteLine("Ingresa el categoria del empleado: ");
        category = Console.ReadLine();
        Console.WriteLine("Ingresa el id del empleado: ");
        id = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa el salario del empleado: ");
        salary = float.Parse(Console.ReadLine());
    }

    public float GetSalary()
    {
        return salary;
    }
}