internal class Program {
    static void Main(string[] args) {

        Console.WriteLine("Digite qual as medidas do triangulo A: ");
        float ax = float.Parse(Console.ReadLine());
        float ay = float.Parse(Console.ReadLine());
        float az = float.Parse(Console.ReadLine());


        Console.WriteLine("Digite qual as medidas do triangulo B: ");
        float bx = float.Parse(Console.ReadLine());
        float by = float.Parse(Console.ReadLine());
        float bz = float.Parse(Console.ReadLine());


        float result_a = area(ax, ay, az);
        float result_b = area(bx, by, bz);


        if (result_a > result_b)
        {
            Console.WriteLine("A area do Triangulo A é Maior que a do Triangulo B");
        }
        else if (result_a < result_b)
        {
            Console.WriteLine("A area do Triangulo B é Maior que a do Triangulo A");
        }
        else
        {
            Console.WriteLine("As Areas do triangulo são iguais!");
        }

        static float area(float a, float b, float c) {
            return a * b * c;
        }


    }
}




