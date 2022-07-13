namespace ExercicioSecao05 {
    internal class Program {
        static void Main(string[] args) {

            double deposito = 0;

            Console.WriteLine("===========================");
            Console.WriteLine("Bem vindo ao Banco CSharp ");
            Console.WriteLine("===========================\n");

            Console.Write("Digite o numero da Conta: ");
            string numconta = Console.ReadLine();

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Deseja fazer deposito: ");
            string x = Console.ReadLine();
            if (x == "s" && x== "S" && x == "Sim" && x == "SIM" && x == "sim")
            {
                Console.Write("Digite o valor do deposito: ");
                 deposito = double.Parse(Console.ReadLine());
            }
           
            ContaBancaria C = new ContaBancaria(numconta, nome, deposito);

            
            Console.WriteLine(C);


        }
    }
}