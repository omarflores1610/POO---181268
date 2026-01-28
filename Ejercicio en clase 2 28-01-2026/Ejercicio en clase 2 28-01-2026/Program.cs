// Author: Omar Ernesto Flores de Hoyos 181268

bool evenorodd (int num)
{
    if (num % 2 == 1)
    {
        Console.WriteLine("El numero es impar");
    } 
    else
    {
        Console.WriteLine("El numero es par");
    }
    return true;
}


int num;


Console.WriteLine("Introduzca el numero para saber si es par o impar");
Console.WriteLine();
num = int.Parse(Console.ReadLine());

evenorodd(num);


