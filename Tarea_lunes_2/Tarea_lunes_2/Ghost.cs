namespace Tarea_lunes_2;

class Ghost : Character
{
    public Ghost(string name) : base(name)
    {
    }

    public void Introduce()
    {
        Console.WriteLine("Hola, yo soy el fantasma, mi nombre es " + name);
    }
}