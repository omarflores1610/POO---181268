// Omar Ernesto Flores de Hoyos 181268

using Ejercicio_2_25_02_2026;

class Examples
{
    static void Main(string[] args)
    {
        Employee[] employees = new Employee[3];
        for (int i = 0; i < employees.Length; i++)
        {
            employees[i] = new Employee();
        }
        Console.WriteLine(employees[0].name,
            ", " + employees[0].category,
            ", " + employees[0].id,
            ", " + employees[0].salary);
        Console.WriteLine(employees[1].name,
            ", " + employees[1].category,
            ", " + employees[1].id,
            ", " + employees[1].salary);
        Console.WriteLine(employees[2].name,
            ", " + employees[2].category,
            ", " + employees[2].id,
            ", " + employees[2].salary);
    }
}