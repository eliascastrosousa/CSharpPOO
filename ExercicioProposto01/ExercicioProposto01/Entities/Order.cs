using System;
using System.Text;
using System.Threading.Tasks;
using ExercicioProposto01.Entities;
using ExercicioProposto01.Entities.Enums;

namespace ExercicioProposto01.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        public List<OrderItem> items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
          
        }

        public void AddItem(OrderItem item)
        {
            items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach(OrderItem item in items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Moment: "+ Moment.ToString("dd/MM/yyyy"));
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items ");
            foreach(OrderItem item in items)
            {
                sb.Append(item.ToString());
            }
            sb.AppendLine("Total Price: " + Total());
            return sb.ToString();
        }



    }
}
