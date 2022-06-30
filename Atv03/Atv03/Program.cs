using System;
using System.Globalization;

namespace ConvencoesParaNomes { //
    class Convencoes { // Pascal Case
        public string Titular { get; set; } //Pascal Case: namespaces, classes, properties e metodos.
        private double _saldo; // Padrão com underline: atributos internos da classe

        public void Deposito(double quantia) { //camel Case: metodos, variaveis dentro de metodos
            quantia = 5.1;
            _saldo += quantia;
        }
        public double GetSaldo() {
            return _saldo;
        }

        static void Main() {
            double quantia = 5.1;
            double saldo = 5.984677;
            String nome = "Elias";
            int idade = 26;
            string cidade = "guarulhos";
            //Console.Write(nome);
            Console.WriteLine(quantia);
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture)); //mudar os decimais
            //Console.WriteLine(saldo);

            Console.WriteLine("{0} tem {1} anos e nasceu em {2}. Seu saldo atual é de {3:F2}", nome, idade, cidade, saldo);

            Console.WriteLine($"{nome} tem {idade} anos, nasceu em {cidade} e seu saldo é de {saldo:F2}");

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo de " + saldo.ToString("F2", CultureInfo.InvariantCulture));


        }




    }
}


