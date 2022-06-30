

using System.Globalization;

namespace Ex02EntradaDeDados {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu nome, idade e Altura: ");
            string[] v = Console.ReadLine().Split(' ');

            string n = v[0];
            int id = int.Parse(v[1]);
            float alt = float.Parse(v[2]);



            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n",nome, num, preco, n, id, alt.ToString(CultureInfo.InvariantCulture));

        }
    }
}