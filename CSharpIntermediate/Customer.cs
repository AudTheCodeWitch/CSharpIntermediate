using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer() // Constructor
        {
            Orders = new List<Order>(); // Initialize an empty list to avoid null reference exceptions
        }

        public Customer(int id) // Constructor overloading
            : this() // Constructor chaining includes the default constructor 
        {
            this.Id = id;
        }

        public Customer(int id, string name) // Constructor overloading with chaining
            : this(id) // Constructor chaining includes the constructor with one parameter
        {
            this.Name = name;
        }
    }
}