// Author: Omar Ernesto Flores de Hoyos 181268

int num;

Console.WriteLine("Inserta el numero entero del cual quieres su tabla de multiplicar");
Console.WriteLine();
num = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = num; i < num * 11; i += num)
{
        Console.Write(" " + i);
}
Console.WriteLine();