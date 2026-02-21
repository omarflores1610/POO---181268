// Omar Ernesto Flores de Hoyos 181268

bool Mult3 (int num1)
{
    if (num1 % 3 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool Mult7(int num1)
{
    if (num1 % 7 == 0)
    {
        return true;
    }
    else 
    {
        return false;
    }
}
int num1 = 0;
num1 = int.Parse(Console.ReadLine());
Mult3(num1);
Mult7(num1);
bool mult3 = Mult3(num1);
bool mult7 = Mult7(num1);
if (mult3 ^ mult7)
{
    Console.WriteLine("Correcto");
}
else
{
    Console.WriteLine("Incorrecto");
}