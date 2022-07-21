namespace Ex12_Matrizes {
    internal class Program {
        static void Main(string[] args) {
            int lin, col;

            Console.Write("Digite quantas Linhas a matriz terá: ");
            lin = int.Parse(Console.ReadLine());
            Console.Write("Digite quantas Colunas a matriz terá: ");
            col = int.Parse(Console.ReadLine());

            int[,] m = new int[lin, col];
            for (int i = 0; i < lin; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("Digite o valor da matriz posicao [{0}][{1}]: ", i, j);
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < lin; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("[{0}]", m[i, j]);
                    
                }
                Console.Write("\n");
            }

            Console.WriteLine("==============================");
            Console.Write("Digite um numero que pertence a matriz: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < lin; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (num == m[i,j])
                    {
                        Console.WriteLine("Lado esquerdo: {0}", m[i,j-1]);
                        Console.WriteLine("Lado de Cima: {0}", m[i-1,j] );
                        Console.WriteLine("Lado Direito: {0}", m[i, j+1]);
                        Console.WriteLine("Lado de Baixo: {0}", m[i+1, j]);
                    }
                }
                
            }
            
           







        }
    }
}