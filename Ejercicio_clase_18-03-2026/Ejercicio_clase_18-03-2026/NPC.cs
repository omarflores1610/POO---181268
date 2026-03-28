namespace Ejercicio_clase_18_03_2026;

public class NPC
{
    private string name;

    public NPC()
    {
        this.name = "Juan";
    }

    public void React (string random)
    {
        Console.WriteLine("Estoy confundido");
    }

    public void React(string action, int level)
    {
        if (level < 1 || level > 3)
        {
            Console.WriteLine("Los niveles de reacción van del 1 al 3");
        }
        else if (level == 1)
        {
            Console.WriteLine("Estoy tranquilo");
        }
        else if (level == 2)
        {
            Console.WriteLine("Estoy serio");
        }
        else
        {
            Console.WriteLine("Estoy molesto");
        }
    }

    public void React(string action2, bool friend)
    {
        if (friend = true)
        {
            Console.WriteLine("Abrazo");
        }
        else
        {
            Console.WriteLine("Serio");
        }
    }
}