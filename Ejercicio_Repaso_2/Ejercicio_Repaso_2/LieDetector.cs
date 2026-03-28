namespace Ejercicio_Repaso_2;

public class LieDetector
{
    private string suspectName;
    private string question;
    private int suspicionLevel;
    private int minSuspicion;
    private int maxSuspicion;

    public LieDetector(
        string suspectName,
        string question,
        int suspicionLevel,
        int minSuspicion,
        int maxSuspicion
        )
    {
        this.suspectName = suspectName;
        this.question = question;
        this.suspicionLevel = suspicionLevel;
        this.minSuspicion = minSuspicion;
        this.maxSuspicion = maxSuspicion;
    }

    public void SetQuestion(string newQuestion)
    {
        question = newQuestion;
        Console.WriteLine(question);
    }
    Random rnd = new Random();
    int min = 1;
    int max = 4;
    
    
    public void AnalyzeAnswer(string answer)
    {
        Console.WriteLine("Analyzing");
        int numeroAleatorio = rnd.Next(min, max + 1);
        Console.WriteLine("El valor de sospecha es: " + numeroAleatorio);
    }

    public void Showreport()
    {
        Console.WriteLine("La pregunta analizada es: " + question +  ", y el nivel de sospecha de la respuesta es: " + suspicionLevel);
    }

    public bool IsLier()
    {
        if (suspicionLevel >= 3)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
}