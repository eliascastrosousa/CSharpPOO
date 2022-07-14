using System.Globalization;

namespace ExercicioSecao05
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
            string nome = Console.ReadLine();
            p.SetNome("TV");

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.SetPreco(preco);


            Console.Write("Quantidade: ");
            int qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.SetQuantidade(qtd);


            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Dados do produto: {0} ", p);
            Console.WriteLine("--------------------------------------------------------------");

            Console.Write("\n\nDigite a quantidade de produtos a ser adicionado ao estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);

            Console.WriteLine("\n--------------------------------------------------------------");
            Console.Write("Dados atualizados do estoque: {0}\n", p.GetQuantidade());
            Console.WriteLine("--------------------------------------------------------------");

            Console.Write("\nDigite a quantidade de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);

            Console.WriteLine("\n--------------------------------------------------------------");
            Console.Write("Dados atualizados do estoque: {0}\n", p.GetQuantidade());
            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Dados do produto: {0} ", p);
            Console.WriteLine("--------------------------------------------------------------");


            Console.WriteLine("\nFim!");
        }


    }
}