namespace Lab_Ejercicios_3;

public class CrazyPizza
{
    private string[] validIngredients = { "Queso", "Pepperoni", "Jamón", "Carne molida" };

    public void Order()
    {
        Console.WriteLine("A plain pizza has been delivered!");
    }

    public void Order(string[] ingredients)
    {
        for (int i = 0; i < ingredients.Length; i++)
        {
            bool encontrado = false;
            for (int j = 0; j < validIngredients.Length; j++)
            {
                if (ingredients[i] == validIngredients[j])
                {
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("El ingrediente " + ingredients[i] + " no está disponible");
                return;
            }
        }

        Console.WriteLine("The pizza has been delivered!");
    }

    public void Order(bool extraCheese)
    {
        if (extraCheese)
        {
            Console.WriteLine("A plain pizza with extra cheese has been delivered!");
        }
        else
        {
            Console.WriteLine("A plain pizza has been delivered!");
        }

    }
}