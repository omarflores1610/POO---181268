
using System;
using System.IO;
using System.Diagnostics;
using System.Text;
public class MorseLock : Lock
{
    public MorseLock() : base(23, 2, "veintitres")
    {
        title = "La nota en código Morse";

        description =
            "Entraste al cuarto del guardia y encontraste un papel tirado en el suelo," +
            "está escrito en código Morse y al parecer es un número." +
            "Tradúcelo y úsalo para abrir la primera cerradura";

        hints = new string[2];
        hints[0] = "El mensaje forma una sola palabra, tradúcela letra por letra";
        hints[1] = "La respuesta se puede escribir con números o con letras";
    }

    public override void OpenResource(string folder)
    {
        string fullPath = Path.Combine(folder, "nivel1_morse.txt");

        if (!File.Exists(fullPath))
        {
            Console.WriteLine("No se encontró el archivo: nivel1_morse.txt");
            return;
        }

        FileInfo info = new FileInfo(fullPath);
        Console.WriteLine("Abriendo: nivel1_morse.txt");

        ProcessStartInfo process = new ProcessStartInfo();
        process.FileName = fullPath;
        process.UseShellExecute = true;

        Process.Start(process);
    }
}