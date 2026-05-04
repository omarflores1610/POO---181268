namespace Tarea_lunes_1;

public class Vehicle
{
    protected string brand;
    protected int speed;

    public Vehicle()
    {
        brand = "Porsche";
        speed = 0;
    }

    public void Accelerate()
    {
        speed += 40;
        Console.WriteLine("La nueva velocidad es: " + speed);
    }

    public void Break()
    {
        speed = 0;
    }

    public bool crash()
    {
        if (speed > 100)
        {
            Random rnd = new Random();
            int randNumb = rnd.Next(0, 2);
            if (randNumb == 0)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Haz chocado");
                return true;
            }
        }
        return false;
    }
}
