using Course.Entities;
using Course.Entities.Enums;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string exemploEnumParaString = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(exemploEnumParaString);

            OrderStatus exemploStringParaEnum = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(exemploStringParaEnum);
        }
    }
}
