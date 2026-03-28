// Omar Ernesto Flores de Hoyos 181268
using Ejercicio_Repaso_1;
namespace Ejercicio_Repaso_1
{
    class Program
    {
        static void Main(string[] args)
        {
            HauntedHouse house1 = new HauntedHouse(
                "Haunted House",
                "Main Street",
                4
            );
            house1.SetLevel(5);
            house1.SetLevel(0);
            house1.SetLevel(4);
            house1.ShowInfo();
            house1.SpookVisitors();
        }
    }
}