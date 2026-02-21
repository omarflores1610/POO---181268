// Omar Ernesto Flores de Hoyos 181268

int [] array = {1, 2, 3, 4, 5};

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[(i - 1 + 5)%5] + " ");
}