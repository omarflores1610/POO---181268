// Omar Ernesto Flores de Hoyos
using Lab_Ejercicios_2;

namespace Lab_Ejercicios_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = { "Cancion 1", "Cancion 2", "Cancion 3" };
            Album album = new Album("My Album", songs);
            try
            {
                album.PlaySong("Cancion 1");
                album.PlaySong(1);
                album.PlaySong("No existe");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType().Name);
            }
            try
            {
                album.PlaySong(10);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType().Name);
            }
        }
    }
}