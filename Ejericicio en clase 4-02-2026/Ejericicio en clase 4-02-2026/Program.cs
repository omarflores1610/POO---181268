// Author: Omar Ernesto Flores de Hoyos - 181268

int[] salary = {100, 100, 200, 100};
int averageSalary = 0;
int summation = 0;

for (int i = 0; i < salary.Length; i++)
{
    summation += salary[i];
}
averageSalary = summation / salary.Length;
Console.WriteLine("El salario promedio es: " + averageSalary);

for (int i = 0; i < salary.Length; i++)
{
    if (salary[i] > averageSalary)
    {
        Console.WriteLine("Los salarios que superan el promeido son: " + salary[i]);
    }
}