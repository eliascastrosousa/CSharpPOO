using System.Globalization;

namespace Ex10ConversorMoeda {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Qual a cotação do dolar: ");
            ConversorDeMoeda.cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos Dolares você deseja comprar: ");
            ConversorDeMoeda.dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = {0}", ConversorDeMoeda.conversao().ToString("F2"));


        }
    }
}