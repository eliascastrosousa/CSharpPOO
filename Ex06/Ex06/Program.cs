namespace Ex06 {
    internal class Program {
        static void Main(string[] args) {

            Retangulo r;
            r = new Retangulo();

            Console.WriteLine("Digite a Largura e Altura do retangulo: ");
            r.largura = double.Parse(Console.ReadLine());
            r.altura = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Largura {0} e Altura do retangulo {1}", r.largura, r.altura );
            Console.WriteLine("-------------------------------------------\n\n");

            Console.WriteLine("-------------------------------------------");
            double a = r.Area(r.largura, r.altura);
            Console.WriteLine("AREA: {0}", a);
            Console.WriteLine("-------------------------------------------\n\n");

            Console.WriteLine("-------------------------------------------");
            double p = r.Perimetro(r.largura, r.altura);
            Console.WriteLine("Perimetro: {0}", p);
            Console.WriteLine("-------------------------------------------\n\n");

            Console.WriteLine("-------------------------------------------");
            double d = r.Diagonal(r.largura, r.altura);
            Console.WriteLine("Diagonal: {0}", d);
            Console.WriteLine("-------------------------------------------\n\n");
        }
    }
}