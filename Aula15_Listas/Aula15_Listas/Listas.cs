using System;
using System.Collections.Generic;


namespace Aula15_Listas {
    internal class Listas {
        public void lista() {
            //List<string> list = new List<string>();
            Console.WriteLine("Adicionando nomes...");

            List<string> list = new List<string> {"Anna", "Lucia", "Maria", "Ricardo", "Josué"};


            list.Add("Oseas");
            list.Add("Karina");
            list.Add("Aline");

            //list.Clear(); // remove todos os elementos da lista
            list.Insert(2, "Bata vladivski");

            Console.WriteLine("QTD de nomes: "+list.Count());
            /*
            Console.WriteLine("Digite um nome: ");
            list.Add(Console.ReadLine());

            Console.WriteLine("Digite outro nome e a posição que será inserida: ");
            string nome = Console.ReadLine();
            int posicao = int.Parse(Console.ReadLine());
            list.Insert(posicao, nome);


            Console.WriteLine("Quantidade de Nomes: "+  list.Count());
            */
            foreach (string obj in list)
            {
                Console.WriteLine("Mostrando os nomes:" + obj);
            }
            Console.WriteLine("\nEncontrar nome");
            Console.WriteLine("----------------------------------------------------------------");
            Console.Write("Digite uma letra para encontrar o primeiro nome com essa inicial: ");
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------------------");
            string s1 = list.Find(x => x[0] == c);
            Console.WriteLine("nome com {0}: {1}",c,s1 );

            Console.WriteLine("----------------------------------------------------------------");
            Console.Write("Digite uma letra para encontrar o ultimo nome com essa inicial: ");
            c = char.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------------------");
            string s2 = list.FindLast(x => x[0] == c);
            Console.WriteLine("nome com {0}: {1}", c, s2);


        }

        public void InsereLista() {
            List<string> list = new List<string>();
            list.Add(Console.ReadLine());
        }
        public void ConsultaLista() {
            List<string> list = new List<string>();

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            };
        }

        static bool Test(string s) {
            return s[0] == 'A';
        }

    }
}
