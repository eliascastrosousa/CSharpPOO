using System;
using System.Globalization;


namespace Ex1 {
    class Program {

        static void Main(string[] args) {
            string produto1 = "computador";
            string produto2 = "mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: \nComputador, cujo preço é $ " + preco1 + "\nMesa de escritorio, cujo preço é $ " + preco2);
            Console.WriteLine("\n\nRegistros: {0} anos de idade, Codigo {1} e Genero: {2}.", idade, codigo, genero);
            Console.WriteLine($"\n\nMedida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"arredondado: {medida:F3}");
            Console.WriteLine($"Separador Decimal: {medida.ToString("F3", CultureInfo.InvariantCulture)}");




            Console.WriteLine("completar depois.");
        }
    }
}

