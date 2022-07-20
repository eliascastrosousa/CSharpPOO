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

            Console.WriteLine("Digite um nome: ");
            list.Add(Console.ReadLine());

            Console.WriteLine("Digite outro nome e a posição que será inserida: ");
            string nome = Console.ReadLine();
            int posicao = int.Parse(Console.ReadLine());
            list.Insert(posicao, nome);


            Console.WriteLine("Quantidade de Nomes: "+  list.Count());

            foreach (string obj in list)
            {
                Console.WriteLine("Mostrando os nomes:" + obj);
            }

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

    }
}
