namespace Tarea_lunes_1;

class Car : Vehicle
{
    private int doors;

    public Car(int numbOfDoors)
    {
        doors = numbOfDoors;
    }

    public void OpenTrunk()
    {
        if (doors % 2 != 0)
        {
            Console.WriteLine("La cajuela se abrió");
        }
        else
        {
            Console.WriteLine("El carro no tiene cajuela");
        }
    }
}