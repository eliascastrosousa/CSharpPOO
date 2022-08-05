using ExercicioResolvido01.Entities;
using ExercicioResolvido01.Entities.Enums;
using System.Globalization;
namespace ExercicioResolvido01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ler os dados de um trabalhador com N contratos (fornecido pelo usuario). " +
                "Depois solicitar do usuario um mes e mostral qual foi o salario do funcionario nesse mes, " +
                "conforme exemplo (proxima pagina)\n\n");
            
            Console.Write("Enter departament's name: ");
            string deptName = Console.ReadLine();

            Console.Write("Enter worker date: ");

            Console.Write("Name: ");
            string Name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel Level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            //objeto workerlevel level recebe convertendo oq o usuario digitar para enum

            Console.Write("Base Salary: ");
            double BaseSalariy = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament Dept = new Departament(deptName);
            Worker worker = new Worker(Name, Level, BaseSalariy, Dept);

            Console.Write("How Many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.Write("Enter #{0} contract data: ", i);
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double ValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (Hours): ");
                int hours = int.Parse(Console.ReadLine());

                //instanciar o contrato

                HourContract contract = new HourContract(date, ValuePerHour, hours);
                Console.WriteLine("instanciando contrato...");
                worker.AddContract(contract);
                Console.WriteLine("Contrato adicionado ao Worker.");
                
            } 
            Console.WriteLine("\nEnter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0,2));
            int year = int.Parse(monthAndYear.Substring(3,4));
            Console.WriteLine("Mês: {0}\nAno: {1}\n", month, year);

            Console.WriteLine("Nome: {0}", worker.Name);
            Console.WriteLine("Departament: {0}", worker.Departament.Name);
            Console.WriteLine("Income for {0}: {1}", monthAndYear, worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}