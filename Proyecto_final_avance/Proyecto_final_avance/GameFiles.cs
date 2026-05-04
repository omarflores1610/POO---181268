
using System;
using System.IO;
using System.Diagnostics;
using System.Text;

public class GameFiles
{
    public static void CreateAll(string folder)
    {
        if (!Directory.Exists(folder))
        {
            Directory.CreateDirectory(folder);
        }

        CreateMorseFile(folder);
        CreateBrokenCodeFile(folder);
    }

    private static void CreateMorseFile(string folder)
    {
        string path = Path.Combine(folder, "nivel1_morse.txt");

        if (File.Exists(path) && new FileInfo(path).Length > 0)
        {
            return;
        }

        using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
        {
            sw.WriteLine("MENSAJE EN CÓDIGO MORSE");
            sw.WriteLine();
            sw.WriteLine();
            sw.WriteLine("El papel dice:");
            sw.WriteLine();
            sw.WriteLine("...-  /  .  /  ..  /  -.  /  -  /  ..  /  -  /  .-.  /  .  /  ...");
            sw.WriteLine();
            sw.WriteLine("Cada grupo separado por / es una letra.");
            sw.WriteLine();
            sw.WriteLine();
            sw.WriteLine();
            sw.WriteLine("ALFABETO MORSE");
            sw.WriteLine();
            sw.WriteLine();
            sw.WriteLine("A  .-      B  -...    C  -.-.    D  -..     E  .");
            sw.WriteLine("F  ..-.    G  --.     H  ....    I  ..      J  .---");
            sw.WriteLine("K  -.-     L  .-..    M  --      N  -.      O  ---");
            sw.WriteLine("P  .--.    Q  --.-    R  .-.     S  ...     T  -");
            sw.WriteLine("U  ..-     V  ...-    W  .--     X  -..-    Y  -.--");
            sw.WriteLine("Z  --..");
            sw.WriteLine();
            sw.WriteLine("0  -----   1  .----   2  ..---   3  ...--   4  ....-");
            sw.WriteLine("5  .....   6  -....   7  --...   8  ---..   9  ----.");
        }
    }

    private static void CreateBrokenCodeFile(string folder)
    {
        string path = Path.Combine(folder, "Mi_primer_cod.txt");

        if (File.Exists(path) && new FileInfo(path).Length > 0)
        {
            return;
        }

        using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
        {
            sw.WriteLine("// Mi primer código :D");
            sw.WriteLine("// Lo escribí rápido, algo está mal.");
            sw.WriteLine("// Si lo corrijo, ¿qué imprimiría?");
            sw.WriteLine();
            sw.WriteLine("    int resultado = 0");
            sw.WriteLine("    for (int i = 1; i <= 6; i++)");
            sw.WriteLine("    {");
            sw.WriteLine("        if (i % 2 = 0)");
            sw.WriteLine("        {");
            sw.WriteLine("            resultado =+ i * 3;");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("    Console.WrtieLine(resultado)");
        }
    }

    public static void OpenReward(string folder)
    {
        string fullPath = Path.Combine(folder, "recompensa.png");

        if (!File.Exists(fullPath))
        {
            Console.WriteLine("No se encontró el archivo de recompensa.");
            return;
        }

        FileInfo info = new FileInfo(fullPath);
        Console.WriteLine("Abriendo recompensa: recompensa.png");

        ProcessStartInfo process = new ProcessStartInfo();
        process.FileName = fullPath;
        process.UseShellExecute = true;

        Process.Start(process);
    }
}
