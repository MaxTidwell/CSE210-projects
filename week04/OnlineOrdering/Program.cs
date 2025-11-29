using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address addr1 = new Address("123 Main St", "Salt Lake City", "UT", "USA");
        Address addr2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        // Create customers
        Customer cust1 = new Customer("Dave Davison", addr1);
        Customer cust2 = new Customer("Alice Johnson", addr2);

        // Create orders
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "P001", 1200.00, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25.00, 2));

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Desk Chair", "P003", 150.00, 1));
        order2.AddProduct(new Product("Monitor", "P004", 300.00, 2));
        order2.AddProduct(new Product("Keyboard", "P005", 75.00, 1));

        // Store orders in a list
        List<Order> orders = new List<Order> { order1, order2 };

        // Display results
        foreach (Order o in orders)
        {
            Console.WriteLine(o.GetPackingLabel());
            Console.WriteLine(o.GetShippingLabel());
            Console.WriteLine($"Total Price: ${o.GetTotalPrice()}\n");
        }
    }
}