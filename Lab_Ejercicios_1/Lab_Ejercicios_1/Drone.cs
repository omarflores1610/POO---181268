namespace Lab_Ejercicios_1_23;

public class Drone
{
    private int battery;
    private int height;
    private bool droneOn;

    public Drone()
    {
        battery = 100;
        height = 0;
        droneOn = true;
    }

    public void SetCharge(int newCharge)
    {
        if (newCharge > 100)
        {
            Console.WriteLine("No se puede cargar la batería a más del 100%");
            return;
        }

        if (newCharge < 0)
        {
            Console.WriteLine("La batería no puede ser negativa");
            return;
        }

        battery = newCharge;
    }

    public void SetHeight(int newHeight)
    {
        if (!droneOn)
        {
            Console.WriteLine("El dron está apagado");
            return;
        }

        if (newHeight < 0)
        {
            Console.WriteLine("La altura ingresada no es válida");
            return;
        }

        if (battery < 40)
        {
            Fall();
            return;
        }

        height = newHeight;
        battery -= 40;

        Console.WriteLine("La nueva altura es: " + height);

        if (battery < 0)
        {
            Fall();
        }
    }

    public void Fall()
    {
        droneOn = false;
        height = 0;
        Console.WriteLine("El dron ha caído");
    }
}