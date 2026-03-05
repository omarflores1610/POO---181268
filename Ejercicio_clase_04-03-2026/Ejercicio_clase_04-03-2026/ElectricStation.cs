namespace Ejercicio_clase_04_03_2026;

public class ElectricStation
{
    private string stationName;
    private int charge;
    private string password;

    public ElectricStation(
        string stationName,
        int charge,
        string password
    )
    {
        this.stationName = stationName;
        this.charge = charge;
        this.password = password;
    }

    public void SetCharge(int newCharge)
    {
        if (newCharge > 100)
        {
            Console.WriteLine("La carga excede el máximo de 100");
        }
        else if (newCharge < 0)
        {
            Console.WriteLine("La carga no puede tener un valor negativo");
        }
        else
        {
            charge = newCharge;
        }
    }
    public int GetCharge()
    {
        return charge;
    }
    public void SetStationName(string password, string setStationName)
    {
        if (this.password == password)
        {
            stationName = setStationName;
        }
        else
        {
            Console.WriteLine("La contraseña es incorrecta");
            Console.WriteLine("La estación se sigue llamando Electric Station");
        }
    }
    public string GetStationName()
    {
        return stationName;
    }
    
}