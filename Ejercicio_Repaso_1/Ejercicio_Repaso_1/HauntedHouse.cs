namespace Ejercicio_Repaso_1;

public class HauntedHouse
{
    private string name;
    private string adress;
    private int horrorLevel;
    
    public HauntedHouse(
        string name,
        string adress,
        int horrorLevel)
    {
        this.name = name;
        this.adress = adress;
        this.horrorLevel = horrorLevel;
    }

    public void SetLevel(int newLevel)
    {
        if (newLevel < 0 || newLevel > 4)
        {
            Console.WriteLine("No puedes ingresar este nivel de terror, solo puedes ingresar del 1 al 4");
            Console.WriteLine();
        }
        else
        {
            horrorLevel = newLevel;
        }
    }
    public void ShowInfo()
    {
        Console.WriteLine(name + ", " +  adress + ", " + horrorLevel);
        Console.WriteLine();
    }

    public void SpookVisitors()
    {
        Console.WriteLine("BOOOOOOOO");
    }
}
