namespace Aula16_Matrizes {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");
            Console.Write("digite um numero inteiro N: ");
            int n = int.Parse(Console.ReadLine());
            int c = 0;
            int[,] m = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Digite o valor da matriz posicao [{0}][{1}]: ", i, j);
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("valor da matriz: ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", m[i, j]);

                }
                Console.Write("\n");
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (m[i, j] < 0)
                    {
                        c++;
                    }

                }
            }
            Console.Write("Diagonal principal: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write(m[i, j]);
                    }
                }
            }
            Console.WriteLine("\nA matriz tem {0} numeros negativos", c);

        }
    }
}