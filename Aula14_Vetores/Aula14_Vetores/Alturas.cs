using System.Globalization;


namespace Aula14_Vetores {
    internal class Alturas {
        
        public void Altura() {
            Console.Write("Leitor de altura \n\nDigite a Qtd de alturas que irão entrar: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite a altura: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Altura [{0}] = {1}", i, vect[i]);
            }

            double media = 0;

            for (int i = 0; i < n; i++)
            {
                media += vect[i];
            }
            media = media / n;

            Console.WriteLine("\nMedia de altura: {0}", media.ToString("F2", CultureInfo.InvariantCulture));
        }

        



    }
}
