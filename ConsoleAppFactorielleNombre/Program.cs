namespace ConsoleAppFactorielleNombre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            long factorielle;

            while (true)
            {
                Console.WriteLine("Entrez un nombre entier positif :");
                n = int.Parse(Console.ReadLine());

                if (n < 0)
                {
                    Console.WriteLine("La factorielle n'existe pas pour un nombre négatif.");
                    continue;
                }

                factorielle = 1;
                string detail = "";

                for (int i = 1; i <= n; i++)
                {
                    factorielle *= i;

                    if (i > 1)
                    {
                        detail += " * ";
                    }
                    detail += i;
                }

                if (n == 0)
                {
                    detail = "1";
                }

                Console.WriteLine($"{n}! = {detail} = {factorielle}");
                
            }
        }
    }
}
