namespace Tarea_lunes_2;

public class Character
{
    protected string name;

    public Character(string newName)
    {
        this.name = newName;
    }

    public void Introduce()
    {
        Console.WriteLine("Hola, mi nombre es " + name);
    }
}