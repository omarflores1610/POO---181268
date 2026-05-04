// Omar Ernesto Flores de Hoyos 181268

using System.IO;

class excersise
{
    static void Main()
    {
        using(StreamWriter sw = 
              new StreamWriter("C:\\Users\\Propietario\\Desktop\\my_file\\ArchivoPOO2.txt"))
        {
            sw.WriteLine("El nitrógeno presente en nuestro ADN,");
            sw.WriteLine("el calcio de nuestros dientes, el hierro de nuestra sangre,");
            sw.WriteLine("el carbono en las tartas de manzana…");
            sw.WriteLine("todos fueron creados en el interior de estrellas que chocaron entre sí.");
            sw.WriteLine("Estamos hechos del material de las estrellas.");
            sw.WriteLine("                                             Carl Sagan.");
        }

        using (StreamReader sr = new
                   StreamReader("C:\\Users\\Propietario\\Desktop\\my_file\\ArchivoPOO2.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        string path = "C:\\Users\\Propietario\\Desktop\\my_file\\ArchivoPOO2.txt";
        FileInfo fileInfo = new FileInfo(path);
        Console.WriteLine("EL tamaño del archivo es: " + fileInfo.Length + " bytes");
    }
}