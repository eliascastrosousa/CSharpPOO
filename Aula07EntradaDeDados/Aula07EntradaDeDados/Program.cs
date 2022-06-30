namespace Aula07EntradaDeDados {
    internal class Program {
        static void Main(string[] args) {
            /*
            Console.WriteLine("Digite: ");
            string frase = Console.ReadLine();
            string x = Console.ReadLine();

            Console.WriteLine("Você digitou: {0}\n{1}",frase, x);

            Console.WriteLine("Digite quantos nomes quiser: ");
            string[] vet = Console.ReadLine().Split(' ') ;

            Console.WriteLine("Mostrando os resultados: ");
            for (int i = 0; i < vet.Length; i++) { 
                Console.WriteLine(vet[i]);
            } */

            int n;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);

            Console.WriteLine("Digite o nome, idade e salario: ");
            string[] v = Console.ReadLine().Split(' ');

            string nome = v[0];
            int idade = int.Parse(v[1]);
            float salario = float.Parse(v[2]);

            Console.WriteLine("\n\nnome: {0}, idade: {1} e Salario: {2}", nome, idade, salario);


        }
    }
}