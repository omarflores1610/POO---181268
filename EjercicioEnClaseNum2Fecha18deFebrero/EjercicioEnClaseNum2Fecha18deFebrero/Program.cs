// Omar Ernesto Flores de Hoyos 181268
using EjercicioEnClaseNum2Fecha18deFebrero;
class Books
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingresa los datos del libro, primero, autor");
        string author = Console.ReadLine();
        Console.WriteLine("Ingresa el titulo");
        string title = Console.ReadLine();
        Console.WriteLine("Ingresa el número de páginas");
        int pages = int.Parse(Console.ReadLine());
        Book book = new Book(author, title, pages);
        book.ShowInfo();
        book.Open();
        book.Close();
    }
}