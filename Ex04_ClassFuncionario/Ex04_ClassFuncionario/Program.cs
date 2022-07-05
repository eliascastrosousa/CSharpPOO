namespace Ex04_ClassFuncionario {
    internal class Program {
        static void Main(string[] args) {

            Funcionario Func_x, Func_y;

            Func_x = new Funcionario();
            Func_y = new Funcionario();

            Console.Write("Digite o nome do Primeiro Funcionario: ");
            Func_x.nome = Console.ReadLine();
            Console.Write("Digite o Salario do Primeiro Funcionario: ");
            Func_x.salario = double.Parse(Console.ReadLine());

            Console.Write("Digite o nome do Segundo Funcionario:  ");
            Func_y.nome = Console.ReadLine();
            Console.Write("Digite o Salario do Segundo Funcionario: ");
            Func_y.salario = double.Parse(Console.ReadLine());

            double media = (Func_x.salario + Func_y.salario) / 2;

            Console.WriteLine("A media de Salarios é de: {0}", media);



        }
    }
}