// Omar Ernesto Flores de Hoyos - 181268

int[] folio = {10, 14, 101, 105, 801, 1607, 2034, 5607};
int folioUser = 0;
bool validFolio = false;

Console.WriteLine("Inserte el folio que desea buscar");
Console.WriteLine();
folioUser = int.Parse(Console.ReadLine());

for (int i = 0; i < folio.Length; i++)
{
    if (folioUser == folio[i])
    {
        validFolio = true;
    }
    
}

if (validFolio)
{
    Console.WriteLine("El folio es válido");
}
else
{
    Console.WriteLine("El folio no es válido");
}