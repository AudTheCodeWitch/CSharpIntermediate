
using System;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(id: 1, name: "John");

            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
