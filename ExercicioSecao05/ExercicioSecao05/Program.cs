namespace ExercicioSecao05 {
    internal class Program {
        static void Main(string[] args) {

            double deposito = 0;
            string Nome = null; 

            Console.WriteLine("===========================");
            Console.WriteLine("Bem vindo ao Banco CSharp ");
            Console.WriteLine("===========================\n");

            Console.Write("Digite o numero da Conta: ");
            string numconta = Console.ReadLine();

            Console.Write("Digite o nome: ");
            string count = Console.ReadLine();

            if (count.Length >= 2)
            {
                Nome = count;
            }
            else
            {
                Console.WriteLine("Não foi possivel Cadastrar o nome!");
                Nome = "erro";
            }

            Console.Write("Deseja fazer deposito: [s] ou [n]: ");
            char x = char.Parse(Console.ReadLine());

            if (x == 's')
            {
                Console.Write("\nDigite o valor do deposito: ");
                deposito = double.Parse(Console.ReadLine());
            }

            ContaBancaria C = new ContaBancaria(numconta, Nome, deposito);


            Console.WriteLine(C);


        }
    }
}