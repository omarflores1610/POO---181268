// Omar Ernesto Flores de Hoyos 181268
using Tarea_lunes_2;
namespace  Tarea_lunes_2;
class Program
{
    static void Main(string[] args)
    {
        Character newCharacter = new Character("Juan");
        newCharacter.Introduce();
        Ghost newGhost = new Ghost("Pedro");
        newGhost.Introduce();
    }
}