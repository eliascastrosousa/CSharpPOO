using System;

namespace Aula14_Vetores {
    internal class RegistrarAluguel {
        public void RegistrarAlugueis() {
            int QuartosDisponiveis = 10;
            Pensionato[] pensao = new Pensionato[QuartosDisponiveis - 1];

            Console.Write("\nQuantos Quartos serão alugados?  ");
            int n = int.Parse(Console.ReadLine());

            if (n <= QuartosDisponiveis)
            {
                string nome;
                string email;

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("\n----------------");
                    Console.WriteLine("{0}ª Reserva", i+1);
                    

                    Console.Write("Nome do Estudante: ");
                    nome = Console.ReadLine();

                    Console.Write("Email do Estudante: ");
                    email = Console.ReadLine();

                    Console.Write("Numero do Quarto Escolhido: ");
                    int v = int.Parse(Console.ReadLine());

                    pensao[v] = new Pensionato { Name = nome, Email = email };
                    Console.WriteLine("----------------");

                }
                Console.WriteLine("\n");
                for (int i = 0; i < QuartosDisponiveis; i++)
                {
                    if (pensao[i] != null)
                    {
                        Console.WriteLine("Nome do Estudante do Quarto [{0}]: {1}", i, pensao[i].Name);
                        Console.WriteLine("Email do Estudante do Quarto [{0}]: {1}", i, pensao[i].Email);

                    }
                    
                }
            }
            else
            {
                Console.WriteLine("\nNão temos vagas suficientes.");
            }

        }
    }
}
