using ExercicioProposto01.Entities;
using ExercicioProposto01.Entities.Enums;

namespace ExercicioProposto01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ler os dados de um pedido com N itens (fornecido pelo usuario). " +
                "Depois, mostrar um sumario do pedido conforme exemplo (proxima pagina). " +
                " Nota: o instante do pedido deve ser o instante do sistema. \n\n");

            Console.WriteLine("Enter client data");
            Client client = new Client();

            Console.Write("Name: ");
            client.Name = Console.ReadLine();
            Console.Write("Email: " );
            client.Email = Console.ReadLine();
            Console.Write("Birth date: ");
            client.BirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter Order data");
            Console.Write("Status: ");
            OrderStatus oStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, oStatus, client);


            Console.Write("How many itens to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter #{0} item Data: ", i+1);
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine());

                Product prod = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int ProductQuantity = int.Parse(Console.ReadLine());

                OrderItem OrderItem = new OrderItem(ProductQuantity, productPrice, prod);

                order.AddItem(OrderItem);
            }
            Console.WriteLine("Order Summary:\n");
            Console.WriteLine(order);


        }
    }
}