namespace Ejercicio_Trees;

public class Trees
{
    private int size = 100;
    private string foliage = "Too much";

    public Trees()
    {}
    public void Bloom()
    {
        size = size + 10;
        Console.WriteLine("The new size is: " + size);
    }

    public void Dry()
    {
        if (foliage == "Too much")
        {
            foliage = "Not too much";
        }
        else if (foliage == "Not too much")
        {
            foliage = "None";
        }
        else if (foliage == "None")
        {
            foliage = "None";
        }
        Console.WriteLine("The new foliage is: " + foliage);
    } 
}