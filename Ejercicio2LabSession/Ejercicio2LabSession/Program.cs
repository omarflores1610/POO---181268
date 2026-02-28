// Omar Ernesto Flores de Hoyos 181268
using Ejercicio2LabSession;

class examples
{
    static void Main(string[] args)
    {
        Employee[] employee = new Employee[4];
        for (int i = 0; i < 4; i++)
        {
            employee[i] = new Employee();
        }

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(employee[i].name + ", " + employee[i].category + ", " + employee[i].id + ", " +  employee[i].salary);
            Console.WriteLine();
        }

        float sum = 0;
        for (int i = 0; i < 4; i++)
        {
            sum = sum + employee[i].salary;
        }
        
        float averageSalary = sum / employee.Length;
        for (int i = 0; i < employee.Length; i++)
        {
            if (employee[i].salary < averageSalary)
            {
                Console.WriteLine("El siguiente empleado gana menos que el promedio(" + averageSalary + ") es: " + employee[i].name);
            }
        }
    }
}

