namespace Ex07 {
    internal class Program {
        static void Main(string[] args) {

            Funcionario f;
            f = new Funcionario();

            Console.WriteLine("Digite o nome: ");
            f.nome = Console.ReadLine();

            Console.WriteLine("Digite o Salario bruto: ");
            f.salarioBruto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do imposto: ");
            f.imposto = double.Parse(Console.ReadLine());


            double salLiq = f.salarioLiquido();
            Console.WriteLine("Funcionario: {0}, Salario : {1}", f.nome, f.salarioLiquido());

            Console.WriteLine("Digite a porcentagem de aumento do salario: ");
            double aumento = double.Parse(Console.ReadLine());
            //aumento = aumento / 10;

            f.AumentoSalario(aumento);

            Console.WriteLine("Funcionario: {0}, Salario : {1}", f.nome, f.salarioLiquido());


        }
    }
}