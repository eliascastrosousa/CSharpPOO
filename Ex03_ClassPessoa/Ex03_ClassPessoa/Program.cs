namespace Ex03_ClassPessoa {
    internal class Program {
        static void Main(string[] args) {

            Pessoa x, y;
            x = new Pessoa();
            y = new Pessoa();

            Console.Write("Digite o nome da 1º Pessoa: ");
            x.nome = Console.ReadLine();

            Console.Write("Digite a idade da 1º Pessoa: ");
            x.idade = int.Parse(Console.ReadLine());

            Console.WriteLine(x.nome);
            Console.WriteLine(x.idade);

            Console.Write("Digite o nome da 2º Pessoa: ");
            y.nome = Console.ReadLine();

            Console.Write("Digite a idade da 2º Pessoa: ");
            y.idade = int.Parse(Console.ReadLine());

            Console.WriteLine(y.nome);
            Console.WriteLine(y.idade);

            if (x.idade > y.idade)
            {
                Console.WriteLine("Pessoa Mais Velha: {0}", x.nome);
            }
            else if (x.idade < y.idade)
            {
                Console.WriteLine("Pessoa Mais Velha: {0}", y.nome);
            }
            else
            {
                Console.WriteLine("{0} e {1} tem a mesma Idade!!", x.nome, y.nome);
            }



        }
    }
}