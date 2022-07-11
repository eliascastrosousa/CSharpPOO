namespace Ex08Notas {
    internal class Program {
        static void Main(string[] args) {
            
            Aluno al = new Aluno();
            
            Console.WriteLine("Digite seu nome: ");
            al.nome = Console.ReadLine();

            Console.WriteLine("Digite a nota do 1º Trimestre: ");
            al.nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do 2º Trimestre: ");
            al.nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do 3º Trimestre: ");
            al.nota3 = double.Parse(Console.ReadLine());


            Console.WriteLine("\n\nNome: {0}" +
                              "\nNota 1: {1}" +
                              "\nNota 2: {2}" +
                              "\nNota 3: {3}", al.nome, al.nota1, al.nota2, al.nota3);

            double notaFinal = al.AlunoNotas();

            Console.WriteLine("Nota final: {0}", notaFinal);

            if (notaFinal >= 6)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
            }

            


        }
    }
}