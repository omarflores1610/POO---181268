
using System;
using System.IO;
using System.Diagnostics;

public class BrokenCodeLock : Lock
{
    public BrokenCodeLock() : base(7, 2, "siete")
    {
        title = "El código abandonado";

        description =
            "En la siguiente habitación hay una computadora encendida.\n" +
            "Alguien dejó un programa a medias. Está lleno de errores.\n" +
            "Si lo corrijo, ¿qué imprimiría?";

        hints = new string[2];
        hints[0] = "El programa calcula una suma simple. Corrígelo y ejecútalo en tu cabeza.";
        hints[1] = "La respuesta es 7.";
    }

    public override void OpenResource(string folder)
    {
        string fullPath = Path.Combine(folder, "Mi_primer_cod.txt");

        if (!File.Exists(fullPath))
        {
            Console.WriteLine("No se encontró el archivo: Mi_primer_cod.txt");
            Console.WriteLine("Ruta esperada: " + fullPath);
            return;
        }

        FileInfo info = new FileInfo(fullPath);
        Console.WriteLine("Abriendo: Mi_primer_cod.txt (" + info.Length + " bytes)");

        ProcessStartInfo process = new ProcessStartInfo();
        process.FileName = fullPath;
        process.UseShellExecute = true;

        Process.Start(process);
    }
}