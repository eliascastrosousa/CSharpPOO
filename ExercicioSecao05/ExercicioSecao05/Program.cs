using System.Globalization;

namespace ExercicioSecao05 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("===========================");
            Console.WriteLine("Bem vindo ao Banco CSharp ");
            Console.WriteLine("===========================\n");

            Console.Write("Digite o numero da Conta: ");
            int numconta = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Deseja fazer deposito inicial: [s] ou [n]: ");
            char x = char.Parse(Console.ReadLine());
            double valor = 0;
            if (x == 's')
            {
                Console.Write("Digite o valor do Deposito: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }
            else
            {
                valor = 0;
            }

            double deposito = valor;

            ContaBancaria C = new ContaBancaria(numconta, nome, deposito);

            Console.WriteLine("\n===========================");
            Console.WriteLine(C);
            Console.WriteLine("===========================");

            Console.Write("Entre com um valor de deposito: ");
            valor = double.Parse(Console.ReadLine());
            C.Deposito(valor);

            Console.WriteLine("===========================");
            Console.WriteLine(C);
            Console.WriteLine("===========================");

            Console.Write("Entre com um valor de deposito: ");
            valor = double.Parse(Console.ReadLine());
            C.Saque(valor);

            Console.WriteLine("===========================");
            Console.WriteLine(C);
            Console.WriteLine("===========================");

        }
    }
}