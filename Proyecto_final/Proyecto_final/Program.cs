namespace Proyecto_final_avance
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "..", "..", "..", "ArchivosJuego"
            );

            folder = Path.GetFullPath(folder);

            GameFiles.CreateAll(folder);

            int level = 1;
            int totalAttempts = 0;
            bool gameFinished = false;

            Console.WriteLine("==================================");
            Console.WriteLine("         The Safecracker");
            Console.WriteLine("==================================");
            Console.WriteLine();
            Console.WriteLine("Eres un científico infiltrado en una base secreta.");
            Console.WriteLine("La información que necesitas está guardada en una caja fuerte");
            Console.WriteLine("protegida por tres cerraduras.");
            Console.WriteLine("Cada una tiene un patrón. Encuéntralo antes de que");
            Console.WriteLine("el soldado te descubra.");
            Console.WriteLine();
            Console.WriteLine("Presiona ENTER para comenzar.");
            Console.ReadLine();

            while (gameFinished == false)
            {
                Lock currentLock;

                if (level == 1)
                {
                    currentLock = new MorseLock();
                }
                else if (level == 2)
                {
                    currentLock = new BrokenCodeLock();
                }
                else
                {
                    currentLock = new ImageLock();
                }

                Console.WriteLine("----------------------------------");
                Console.WriteLine("NIVEL " + level);
                Console.WriteLine("----------------------------------");
                Console.WriteLine(currentLock.GetTitle());
                Console.WriteLine();
                Console.WriteLine(currentLock.GetDescription());
                Console.WriteLine();

                int hintsThisAttempt = currentLock.GetHintsPerAttempt();

                while (currentLock.GetOpen() == false && currentLock.GetNoAttemptsLeft() == false)
                {
                    Console.WriteLine("Intentos: " + currentLock.GetAttempts() + " / " + currentLock.GetMaxAttempts());
                    Console.WriteLine("Pistas disponibles: " + hintsThisAttempt);
                    Console.WriteLine();
                    Console.WriteLine("1. Abrir archivo");
                    Console.WriteLine("2. Pedir pista");
                    Console.WriteLine("3. Escribir código");
                    Console.WriteLine();
                    Console.Write("Elige una opción: ");

                    string option = Console.ReadLine();

                    Console.WriteLine();

                    if (option == "1")
                    {
                        currentLock.OpenResource(folder);
                    }
                    else if (option == "2")
                    {
                        if (hintsThisAttempt > 0)
                        {
                            Console.WriteLine("Pista: " + currentLock.GiveHint());
                            hintsThisAttempt--;
                        }
                        else
                        {
                            Console.WriteLine("Ya usaste tu pista de este intento.");
                        }
                    }
                    else if (option == "3")
                    {
                        Console.Write("Escribe el código: ");
                        string answer = Console.ReadLine();

                        totalAttempts++;
                        hintsThisAttempt = currentLock.GetHintsPerAttempt();

                        int code;
                        bool correct;

                        if (int.TryParse(answer, out code))
                        {
                            correct = currentLock.TryOpen(code);
                        }
                        else
                        {
                            correct = currentLock.TryOpen(answer);
                        }

                        Console.WriteLine();

                        if (correct)
                        {
                            Console.WriteLine("Correcto. Cerradura abierta.");
                        }
                        else
                        {
                            if (currentLock.GetNoAttemptsLeft())
                            {
                                Console.WriteLine("¡Te descubrió el soldado!");
                            }
                            else
                            {
                                Console.WriteLine("Código incorrecto.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida.");
                    }

                    Console.WriteLine();
                }

                if (currentLock.GetOpen())
                {
                    if (level == 3)
                    {
                        gameFinished = true;
                    }
                    else
                    {
                        level++;
                        Console.WriteLine("Pasas al siguiente nivel.");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("El soldado te encontró. Repites el nivel.");
                    Console.WriteLine("Esta vez ya sabes por dónde va.");
                    Console.WriteLine();
                    Console.WriteLine("Pista automática: " + currentLock.GiveHint(currentLock.GetHintsLength() - 1));
                    Console.WriteLine();
                }
            }

            Console.WriteLine("==================================");
            Console.WriteLine("       CAJA FUERTE ABIERTA");
            Console.WriteLine("==================================");
            Console.WriteLine();
            Console.WriteLine("Lo lograste. La caja fuerte está abierta.");
            Console.WriteLine("Intentos totales: " + totalAttempts);
            Console.WriteLine();
            Console.WriteLine("Dentro encuentras un archivo misterioso...");
            Console.WriteLine();

            GameFiles.OpenReward(folder);

            Console.WriteLine();
            Console.WriteLine("Presiona ENTER para salir.");
            Console.ReadLine();
        }
    }
}