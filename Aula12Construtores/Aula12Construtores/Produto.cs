using System.Globalization;

namespace Aula12Construtores {
    internal class Program {
        static void Main(string[] args) {

            

            Console.WriteLine("=======================================");
            Console.WriteLine("Entre com os dados do produto: ");
            Console.WriteLine("=======================================");

            Console.Write("\nNome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /*
            Console.Write("Quantidade: ");
            int quantd = int.Parse(Console.ReadLine()); */

            Produto p = new Produto(nome, preco); //construtor 

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