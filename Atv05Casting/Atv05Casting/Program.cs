namespace Atv05Casting {
    internal class Program {
        static void Main(string[] args) {
            float x = 4.5f;
            double y = x;
            Console.WriteLine("Conversão implicita: {0}", y);

            double a = 4.5;
            float b = (float)a; //permitir Casting
            Console.WriteLine("Casting: {0}", y);

            int c = (int)a;
            Console.WriteLine("Casting com Int: {0}",  c);

            int d = 2;
            int e = 3;
            double f = (double)d/e;
            Console.WriteLine("Casting com divis]ao de inteiros em double: {0}",f.ToString("F2"));




            


        }
    }
}