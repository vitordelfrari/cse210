using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating address and customer
        Address address1 = new Address("123 Main St", "Cityville", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        // Creating products and order
        Product product1 = new Product("Product A", 101, 10.99, 2);
        Product product2 = new Product("Product B", 102, 5.99, 3);
        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Displaying information for order 1
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice():F2}");
        Console.WriteLine();

        // Creating address and customer for order 2
        Address address2 = new Address("456 Oak St", "Townsville", "NY", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        // Creating products and order
        Product product3 = new Product("Product C", 103, 7.50, 4);
        Order order2 = new Order(customer2);

        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Displaying information for order 2
        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice():F2}");
    }
}
