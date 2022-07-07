using System.Globalization;

namespace Ex05_ClassProduto {
    internal class Program {
        static void Main(string[] args) {

            Produto p;
            p = new Produto();

            Console.WriteLine("=======================================");
            Console.WriteLine("Entre com os dados do produto: ");
            Console.WriteLine("=======================================");

            Console.Write("\nNome: ");
            p.nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            p.quantidade = int.Parse(Console.ReadLine());
            

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Dados do produto: {0} ",p);
            Console.WriteLine("--------------------------------------------------------------");

            Console.Write("\n\nDigite a quantidade de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);

            Console.WriteLine("\n--------------------------------------------------------------");
            Console.Write("Dados atualizados do estoque: {0}\n",p.quantidade) ;
            Console.WriteLine("--------------------------------------------------------------");

            Console.Write("\nDigite a quantidade de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);

            Console.WriteLine("\n--------------------------------------------------------------");
            Console.Write("Dados atualizados do estoque: {0}\n", p.quantidade);
            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Dados do produto: {0} ", p);
            Console.WriteLine("--------------------------------------------------------------");


            Console.WriteLine("\nFim!");
        }
        

    }
}