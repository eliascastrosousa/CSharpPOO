﻿namespace Aula11Funcoes {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite 3 numeros: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);

            Console.WriteLine("O Resultado é: " + resultado);

        }

        static int Maior(int a, int b, int c) {
            int m = 0;

            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > a && b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }

            return m;
        }




    }
}