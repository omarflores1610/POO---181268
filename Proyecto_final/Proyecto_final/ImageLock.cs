
using System;
using System.IO;
using System.Diagnostics;

public class ImageLock : Lock
{
    public ImageLock() : base(89, 2, "ochenta y nueve")
    {
        title = "La imagen cifrada";

        description =
            "La última cerradura. Pegada en la caja fuerte hay una imagen\n" +
            "Hay un número escondido en ella, encuéntralo y abre la caja";

        hints = new string[2];
        hints[0] = "El número está en la imagen, no en las letras grandes. Mira el fondo.";
        hints[1] = "La respuesta es 89.";
    }

    public override void OpenResource(string folder)
    {
        string fullPath = Path.Combine(folder, "nivel3_imagen.png");

        if (!File.Exists(fullPath))
        {
            Console.WriteLine("No se encontró el archivo: nivel3_imagen.png");
            Console.WriteLine("Ruta esperada: " + fullPath);
            return;
        }

        FileInfo info = new FileInfo(fullPath);
        Console.WriteLine("Abriendo: nivel3_imagen.png (" + info.Length + " bytes)");

        ProcessStartInfo process = new ProcessStartInfo();
        process.FileName = fullPath;
        process.UseShellExecute = true;

        Process.Start(process);
    }
}
