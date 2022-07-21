using System;
using System.Globalization;
using System.Collections.Generic;


namespace Ex11Listas {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Quantos funcionarios serão registrados? ");
            int qtd = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for (int c = 0; c < qtd; c++)
            {
                Console.WriteLine("============================");
                Console.WriteLine("Dados do Funcionario {0}", c + 1);
                Console.WriteLine("============================\n");

                Console.Write("Digite o ID do Funcionario: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Digite o Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o Salario: ");
                double salario = double.Parse(Console.ReadLine());

                lista.Add(new Funcionario(id, nome, salario));

            }

            foreach (Funcionario obj in lista)
            {
                Console.WriteLine("\nMostrando os nomes: " + obj + "\n");
            }


            Console.WriteLine("Quantidade de Funcionarios cadastrados: " + lista.Count);

            Console.Write("Digite o ID do funcionario que receberá o aumento: ");
            int _id = int.Parse(Console.ReadLine());
            Funcionario f = lista.Find(x => x.ID == _id);

            if (f != null)
            {
                Console.Write("Digite a porcentagem de aumento de salario que será efetuado: ");
                double porcent = double.Parse(Console.ReadLine());

                f.incrementoSalario(porcent);
                
            }
            else
            {
                Console.WriteLine("Entre com um valor valido!");
            }

            foreach (Funcionario obj in lista)
            {
                Console.WriteLine("\nMostrando os funcionarios: " + obj + "\n");
            }









        }
    }
}