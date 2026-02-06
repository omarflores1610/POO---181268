// Omar Ernesto Flores de Hoyos - 181268

int [] num = new int[10];
int [,] myMatrix = new int[3, 10];

for (int i = 0; i < 10; i++)
{
    Console.Write("Ingresa el numero " +  (i+1) + ": " );
    num[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 10; i++)
{
    myMatrix[0, i] = num[i];
    myMatrix[1, i] = num[i] * num[i];
    myMatrix[2, i] = num[i] * num[i] * num[i];
}

Console.WriteLine("El cuadrado y el cubo de los números ingresados son: ");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.Write(myMatrix[i, j] + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
}