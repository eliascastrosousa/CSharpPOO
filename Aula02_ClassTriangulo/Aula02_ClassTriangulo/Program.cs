using System.Globalization;


namespace Aula02_ClassTriangulo {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite as medidas do Triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite as medidas do Triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double T_x = med(x.A, x.B, x.C);
            double T_y = med(y.A, y.B, y.C);

            Console.WriteLine("A medida do Triangulo X  é: {0}", T_x);
            Console.WriteLine("A medida do Triangulo Y  é: {0}", T_y);

            if (T_x > T_y)
            {
                Console.WriteLine("Triangulo X é o Maior triangulo!");
            }
            else if (T_x < T_y)
            {
                Console.WriteLine("Triangulo Y é o Maior triangulo!");
            }
            else
            {
                Console.WriteLine("Os dois Triangulos tem o mesmo tamanho!!");
            }

        }
        static double med(double x, double y, double z) {
            return (x + y + z) / 2;
        }



    }

}