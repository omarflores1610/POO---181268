// Omar Ernesto Flores de Hoyos 181268
using Tarea_lunes_1;

namespace Tarea_lunes_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car(3);
            newCar.Accelerate();
            newCar.Accelerate();
            newCar.Accelerate();
            newCar.crash();
            newCar.crash();
            newCar.crash();
            newCar.OpenTrunk();
        }
    }
}