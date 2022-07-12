using System;
using System.Globalization;

namespace Ex09CalculoRaio_Instanciado {
    internal class Program {
        static void Main(string[] args) {
            Calculadora Calc = new Calculadora();

            Console.Write("Digite com o valor do Raio: ");
            Calc.r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Circunferencia: " + Calc.Circunferencia(Calc.r).ToString("F2"));
            Console.WriteLine("Volume: " + Calc.Volume(Calc.r).ToString("F2"));
            Console.WriteLine("PI: " + Calc.pi);
        }
    }
}