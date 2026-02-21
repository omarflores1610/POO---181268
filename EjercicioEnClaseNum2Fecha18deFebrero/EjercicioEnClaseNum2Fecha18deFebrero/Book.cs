namespace EjercicioEnClaseNum2Fecha18deFebrero;

public class Book
{
    private string title;
    private string author;
    private int pages;
    private bool open;

    public Book(
        string title,
        string author,
        int pages
        )
    {
        this.title = title;
        this.author = author;
        this.pages = pages;
    }

    public void ShowInfo()
    {
        Console.WriteLine(title);
        Console.WriteLine(author);
        Console.WriteLine(pages);
    }

    public void Open()
    {
        open = true;
    }
    public void Close()
    {
        open = false;
    }
}