using System;
using System.Collections.Generic;

public class Address
{
    private string street;
    private string city;
    private string stateOrProvince;
    private string country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        this.street = street;
        this.city = city;
        this.stateOrProvince = stateOrProvince;
        this.country = country;
    }

    public bool IsInUSA()
    {
        return country.ToUpper() == "USA" || country.ToUpper() == "UNITED STATES";
    }

    public string GetFullAddress()
    {
        return $"{street}\n{city}, {stateOrProvince}\n{country}";
    }
}

public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public string GetName()
    {
        return name;
    }

    public Address GetAddress()
    {
        return address;
    }

    public bool LivesInUSA()
    {
        return address.IsInUSA();
    }
}

public class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public string GetName()
    {
        return name;
    }

    public string GetProductId()
    {
        return productId;
    }

    public double GetPrice()
    {
        return price;
    }

    public int GetQuantity()
    {
        return quantity;
    }

    public double GetTotalCost()
    {
        return price * quantity;
    }
}

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }

        double shippingCost = customer.LivesInUSA() ? 5 : 35;
        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Av. Santa Fe 987", "Buenos Aires", "Capital Federal", "Argentina");
        Address address2 = new Address("Calle San Martín 456", "Mendoza", "Mendoza", "Argentina");

        Customer customer1 = new Customer("Sofía Fernández", address1);
        Customer customer2 = new Customer("Martín Gómez", address2);

        Product prod1 = new Product("Mate Cup", "MATE001", 15.00, 2);
        Product prod2 = new Product("Alfajor", "ALF002", 3.50, 10);
        Product prod3 = new Product("Dulce de Leche", "DUL003", 7.25, 3);
        Product prod4 = new Product("Yerba Mate", "YER004", 12.00, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(prod1);
        order1.AddProduct(prod2);

        Order order2 = new Order(customer2);
        order2.AddProduct(prod3);
        order2.AddProduct(prod4);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice():F2}");
        Console.WriteLine(new string('-', 40));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice():F2}");
        Console.WriteLine(new string('-', 40));
    }
}