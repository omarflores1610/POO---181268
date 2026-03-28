// Omar Ernesto Flores de Hoyos 181268
using Ejercicio_clase_18_03_2026;
namespace Ejercicio_clase_18_03_2026
{
    class Program
    {
        static void Main(string[] args)
        {
            NPC Juan = new NPC();
            Juan.React("Saludar");
            Juan.React("Sacudir", 3);
            Juan.React("Chocarlas", true);
        }
    }
}