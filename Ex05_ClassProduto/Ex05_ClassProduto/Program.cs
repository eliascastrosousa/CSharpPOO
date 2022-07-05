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
            p.preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            p.quantidade = int.Parse(Console.ReadLine());
            double total = ValorTotalEmEstoque(p.preco, p.quantidade);

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Dados do produto: {0}, ${1}, {2} Unidades. Total: {3}", p.nome, p.preco, p.quantidade, total);
            Console.WriteLine("--------------------------------------------------------------");

            Console.Write("\n\nDigite a quantidade de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            
            p.quantidade = AdicionarProdutos(p.quantidade, qtd);
            Console.WriteLine("\n--------------------------------------------------------------");
            Console.Write("Dados atualizados do estoque: {0}\n", p.quantidade);
            Console.WriteLine("--------------------------------------------------------------");

            Console.Write("\nDigite a quantidade de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());

            p.quantidade = RemoverProdutos(p.quantidade, qtd);
            Console.WriteLine("\n--------------------------------------------------------------");
            Console.Write("Dados atualizados do estoque: {0}\n", p.quantidade);
            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine("Fim!");
        }
        static double ValorTotalEmEstoque(double x, int y) {
            double valorTotal = x*y;
            return valorTotal;
        }

        static int AdicionarProdutos(int x, int y) {
            int qtdtotal = x + y;
            return qtdtotal;
        }

        static int RemoverProdutos(int x, int y) {
            int qtdtotal = x - y;
            return qtdtotal;
        }

    }
}