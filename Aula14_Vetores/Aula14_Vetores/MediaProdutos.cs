using System.Globalization;


namespace Aula14_Vetores {
    internal class MediaProdutos {
        public void MediaProduto() {
            Console.Write("\nDigite a Quantidade de produtos que entrarão em estoque: ");
            int n = int.Parse(Console.ReadLine());

            Product[] produto = new Product[n];

            for (int i = 0; i < n; i++)
            {

                Console.Write("Digite o Nome do Produto: ");
                string Nome = Console.ReadLine();

                Console.Write("Digite o Preço do Produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                produto[i] = new Product { Name = Nome, Price = preco };
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nome do Produto [{0}]: {1}", i, produto[i].Name);
                Console.WriteLine("Preço do Produto [{0}]: {1}", i, produto[i].Price);

            }
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += produto[i].Price;
            }
            double avg = sum / n;

            Console.WriteLine("\nSoma dos Valores: {0} \nMedia dos Valores: {1}\n", sum, avg);
        }
    }
}
