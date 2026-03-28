// Omar Ernesto Flores de Hoyos 181268
using Lab_Ejercicios_3;
namespace Lab_Ejercicios_3
{
    class Examples
    {
        static void Main(string[] args)
        {
            CrazyPizza pizza = new CrazyPizza();
            Console.WriteLine("Solo piden pizza:");
            pizza.Order();
            Console.WriteLine("Piden pizza con true en extra queso");
            pizza.Order(true);
            Console.WriteLine("Piden pizza con false en extra queso");
            pizza.Order(false);
            Console.WriteLine("Piden una pizza con ingredientes que sí existen");
            pizza.Order(new string[] { "Queso", "Carne molida" });
            Console.WriteLine("Piden una pizza con un ingrediente que no existe");
            pizza.Order(new string[] { "Queso", "Anchoas" });
        }
    }
}