using System.Globalization;

namespace Ex09CalculoRaio_Statico {
    internal class Program {
        static double pi = 3.14;
        static void Main(string[] args) {

            Console.Write("Digite com o valor do Raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Circunferencia: " + Circunferencia(raio).ToString("F2"));
            Console.WriteLine("Volume: " + Volume(raio).ToString("F2"));
            Console.WriteLine("PI: " + pi);

        }

        static double Circunferencia(double r) {
            return 2 * pi * r;
        }

        static double Volume(double r) {
            return 4.0 / 3.0 * pi * r * r * r;

        }


    }
}