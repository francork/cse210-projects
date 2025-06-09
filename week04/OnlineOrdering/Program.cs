using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Av. Corrientes 1234", "Buenos Aires", "CABA", "Argentina");
        Customer customer1 = new Customer("Lucía Fernández", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Yerba Mate", "Y123", 4.5, 2));
        order1.AddProduct(new Product("Bombilla de acero", "B456", 7.25, 1));

        Address address2 = new Address("1600 Pennsylvania Ave", "Washington", "DC", "USA");
        Customer customer2 = new Customer("James Carter", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Asado argentino", "A789", 15.99, 3));
        order2.AddProduct(new Product("Chimichurri", "C321", 3.5, 2));

        DisplayOrder(order1);
        Console.WriteLine();
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}");
    }
}