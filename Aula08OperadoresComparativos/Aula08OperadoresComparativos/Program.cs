namespace Aula08OperadoresComparativos {
    internal class Program {
        static void Main(string[] args) {
            int a = 10;
            bool x = a < 20;
            bool y = a > 30;
            bool z = a == 20;
            bool w = a != 20;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(w);

            if (x){
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso!!");
            }
        }
    }
}