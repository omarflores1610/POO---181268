using erkhaoerhgetoil;
class Examples
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingresa los datos del libro, primero, autor");
        string name = Console.ReadLine();
        Console.WriteLine("Ingresa el titulo");
        string titulo = Console.ReadLine();
        Console.WriteLine("Ingresa el número de páginas");
        int numeroPaginas = int.Parse(Console.ReadLine());
        Employee armando = new Employee(
            "Armando",
            "Titular B",
            1117117,
            9000
        );
        Console.WriteLine(armando.GetName());
        Console.Read();
    }
}