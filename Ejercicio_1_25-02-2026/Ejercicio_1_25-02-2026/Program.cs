// Omar Ernesto Flores de Hoyos 181268
using Ejercicio_1_25_02_2026;

class Bank
{
    static void Main(string[] args)
    {
        BankAccount Negocio = new BankAccount(
            "Juan Perez",
            1000
        );
        Negocio.ShowBalance();
        Negocio.Deposit(500);
        Negocio.Withdraw(2000);
        Negocio.Deposit(500);
        Negocio.ShowBalance();
    }
    
    
}