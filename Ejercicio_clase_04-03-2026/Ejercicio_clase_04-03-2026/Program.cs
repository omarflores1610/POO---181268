// Omar Ernesto Flores de Hoyos 181268
using Ejercicio_clase_04_03_2026;

namespace Ejercicio_clase_04_03_2026
{
    class Stations
    {
        static void Main(string[] args)
        {
            ElectricStation newStation = new ElectricStation("Electric Station",0,"password");
            newStation.SetCharge(100);
            newStation.SetStationName("contra", "México");
            newStation.SetStationName("password", "México");
            Console.WriteLine(newStation.GetStationName());
            newStation.SetCharge(-1);
        }
    }
}
