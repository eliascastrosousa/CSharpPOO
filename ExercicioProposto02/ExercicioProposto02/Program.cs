using System;
using ExercicioProposto02.Entities;

namespace ExercicioProposto02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of Products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Product #{0} Data: ", i + 1);

                Console.Write("Product is Imported, Common or Used ? (I/C/U): ");
                string opc = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (opc == "I")
                {
                    Console.Write("Customs Fee: ");
                    double customsfee = double.Parse(Console.ReadLine());

                    ImportedProduct importedProduct = new ImportedProduct(name, price, customsfee);
                    products.Add(importedProduct);

                }
                else if(opc == "U")
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    DateTime manufacture = DateTime.Parse(Console.ReadLine());

                    UsedProduct usedproduct = new UsedProduct(name, price, manufacture);
                    products.Add(usedproduct);
                }
                else
                {
                    Product productCommum = new Product(name, price);
                    products.Add(productCommum);
                }
            }
            Console.WriteLine("\nPRICE TAGS: ");
            foreach(Product product in products)
            {
                    Console.WriteLine(product.PriceTag());
            }


            


            


        }
    }
}