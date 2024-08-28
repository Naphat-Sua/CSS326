using System;
using System.Collections.Generic;

class ShoppingCart
{
    private List<string> items;
    private List<double> prices;

    public ShoppingCart()
    {
        items = new List<string>();
        prices = new List<double>();
    }

    public void AddItem(string item, double price)
    {
        items.Add(item);
        prices.Add(price);
        Console.WriteLine($"{item} added to cart.");
    }

    public void DisplayCart()
    {
        double totalPrice = 0;
        Console.WriteLine("\nItems in your cart:");
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{items[i]} - ${prices[i]:F2}");
            totalPrice += prices[i];
        }
        Console.WriteLine($"Total Price: ${totalPrice:F2}");
    }
}

class Program
{
    static void Main()
    {
        ShoppingCart cart = new ShoppingCart();
        string[] availableItems = { "Shirt", "Jeans", "Shoes" };
        double[] prices = { 25.00, 50.00, 75.00 };

        Console.Write("Enter the number of items you want to add: ");
        int numItems = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numItems; i++)
        {
            bool validItem = false;
            while (!validItem)
            {
                Console.WriteLine("\nSelect an item to add to the cart:");
                for (int j = 0; j < availableItems.Length; j++)
                {
                    Console.WriteLine($"{j + 1}. {availableItems[j]} - ${prices[j]:F2}");
                }
                Console.Write("Enter your choice (1-3): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice >= 1 && choice <= availableItems.Length)
                {
                    cart.AddItem(availableItems[choice - 1], prices[choice - 1]);
                    validItem = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }

        cart.DisplayCart();
    }
}
