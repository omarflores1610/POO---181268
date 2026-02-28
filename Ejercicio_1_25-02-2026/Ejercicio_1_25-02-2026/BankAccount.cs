namespace Ejercicio_1_25_02_2026;

public class BankAccount
{
    private string holder;
    private float balance;
    
    public BankAccount(
        string holder,
        float balance)
    {
        this.holder = holder;
        this.balance = balance;
    }

    public void ShowBalance()
    {
        Console.WriteLine("El saldo es de " + balance);
    }

    public void Deposit(float value)
    {
        balance += value;
        Console.WriteLine ("El saldo nuevo es " + balance);
    }

    public void Withdraw(float value)
    {
        balance -= value;
        if (balance < 0)
        {
            balance += value;
            Console.WriteLine("No es posible retirar 2000 ya que es mayor los 1500 que se tienen");
        }
        else
        {
            Console.WriteLine("Tu saldo es " + balance);
        }
    }
}