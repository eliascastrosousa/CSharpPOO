using System.Globalization;

namespace ExercicioSecao05Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto p;
            p = new Produto();

            Console.WriteLine("=======================================");
            Console.WriteLine("Entre com os dados do produto: ");
            Console.WriteLine("=======================================");

            Console.Write("\nDigite o nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /* Quantidade apenas em Somente Leitura
            Console.Write("Quantidade: ");  
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            */


            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Dados do produto: {0} ", p);
            Console.WriteLine("--------------------------------------------------------------");

            Console.Write("\n\nDigite a quantidade de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);

            Console.WriteLine("\n--------------------------------------------------------------");
            Console.Write("Dados atualizados do estoque: {0}\n", p.Quantidade);
            Console.WriteLine("--------------------------------------------------------------");

            Console.Write("\nDigite a quantidade de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);

            Console.WriteLine("\n--------------------------------------------------------------");
            Console.Write("Dados atualizados do estoque: {0}\n", p.Quantidade);
            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Dados do produto: {0} ", p);
            Console.WriteLine("--------------------------------------------------------------");


            Console.WriteLine("\nFim!");
        }


    }
}