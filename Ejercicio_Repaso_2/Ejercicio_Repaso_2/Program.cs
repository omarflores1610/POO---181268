// Omar Ernesto Flores de Hoyso 181268
using Ejercicio_Repaso_2;

namespace Ejercicio_Repaso_2
{
    class Program
    {
        static void Main(string[] args)
        {
            LieDetector Liar = new LieDetector("suspectName", "question", 0, 0, 0);
            Liar.SetQuestion("Estas mintiendo?");
            Liar.AnalyzeAnswer(Console.ReadLine());
            Liar.Showreport();
            Liar.IsLier();
            if (Liar.IsLier() == true)
            {
                Console.WriteLine("Eres un mentiroso");
            }
            else
            {
                Console.WriteLine("No eres un mentiroso");
            }
        }
    }
}