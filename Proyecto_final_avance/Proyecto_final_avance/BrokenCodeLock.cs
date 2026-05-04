
using System;
using System.IO;
using System.Diagnostics;

public class BrokenCodeLock : Lock
{
    public BrokenCodeLock() : base(36, 2, "treinta y seis")
    {
        title = "El código abandonado";

        description =
            "En la habitación hay una computadora encendida," +
            "alguien dejó un programa a medias que tiene muchos errores." +
            "Si lo corrijes, ¿qué va a imprimir?";

        hints = new string[2];
        hints[0] = "El programa acumula un número dentro de un ciclo. Corrígelo e imprime la respuesta";
        hints[1] = "La respuesta está entre 30 y 40";
    }

    public override void OpenResource(string folder)
    {
        string fullPath = Path.Combine(folder, "Mi_primer_cod.txt");

        if (!File.Exists(fullPath))
        {
            Console.WriteLine("No se encontró el archivo: Mi_primer_cod.txt");
            return;
        }

        FileInfo info = new FileInfo(fullPath);
        Console.WriteLine("Abriendo: Mi_primer_cod.txt");

        ProcessStartInfo process = new ProcessStartInfo();
        process.FileName = fullPath;
        process.UseShellExecute = true;

        Process.Start(process);
    }
}