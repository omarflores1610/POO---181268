// Omar Ernesto Flores de Hoyos

using System.IO;

class Archives
{
    static void Main()
    {
        using (StreamReader sr = new
                   StreamReader ("C:/Users/Propietario/Desktop/my_file/ArchivoPOO.txt"))
        {
            string line;
            while ((line = sr.ReadLine ()) != null)
            {
                Console.WriteLine (line);
            }
        }
    }
}