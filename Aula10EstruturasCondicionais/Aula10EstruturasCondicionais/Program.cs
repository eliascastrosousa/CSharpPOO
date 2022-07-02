namespace Aula10EstruturasCondicionais {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digite um numero: ");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
        }
    }
}