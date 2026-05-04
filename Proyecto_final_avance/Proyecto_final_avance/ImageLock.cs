
using System;
using System.IO;
using System.Diagnostics;

public class ImageLock : Lock
{
    public ImageLock() : base(89, 2, "ochenta y nueve")
    {
        title = "La imagen cifrada";

        description =
            "Esta es la última cerradura, en la cual hay una imagen que contiene" +
            "un número escondido en ella, encuéntralo y abre la caja";

        hints = new string[2];
        hints[0] = "No te bases en las letras";
        hints[1] = "La respuesta es un número primo";
    }

    public override void OpenResource(string folder)
    {
        string fullPath = Path.Combine(folder, "nivel3_imagen.png");

        if (!File.Exists(fullPath))
        {
            Console.WriteLine("No se encontró el archivo: nivel3_imagen.png");
            return;
        }

        FileInfo info = new FileInfo(fullPath);
        Console.WriteLine("Abriendo: nivel3_imagen.png");

        ProcessStartInfo process = new ProcessStartInfo();
        process.FileName = fullPath;
        process.UseShellExecute = true;

        Process.Start(process);
    }
}
