using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basic_Inventory_Management_Sytem;

public class Program
{
    private static List<Item> items = new List<Item>();

    public static void Main(string[] args)
    {
        while (true)
        {
            ShowMenu();
            var userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    AddNewItem();
                    break;
                case "2":
                    ListAllItems();
                    break;
                case "3":
                    UpdateItem();
                    break;
                case "4":
                    RemoveItem();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }
        }
    }

    private static void AddNewItem()
    {
        Console.WriteLine("Enter item details: <name> <quantity> <price>");
        var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        if (input.Length != 3 || !int.TryParse(input[1], out int quantity) || !decimal.TryParse(input[2], out decimal price))
        {
            Console.WriteLine("Invalid input! Please enter the details in the correct format.");
            return;
        }

        var name = input[0].ToLower();

        if (items.Any(x => x.Name == name))
        {
            Console.WriteLine("Invalid input. Item is already in the inventory.");
        }
        else
        {
            items.Add(new Item(name, quantity, price));
            Console.WriteLine($"You've successfully added {quantity} {name}/s at a total price of ${price:f2}!");
        }
    }

    private static void ListAllItems()
    {
        if (items.Count == 0)
        {
            Console.WriteLine("No items in inventory!");
            return;
        }

        foreach (var item in items)
        {
            Console.WriteLine($"Item: {item.Name} | Quantity: {item.Quantity} | Price: ${item.Price}");
        }
    }

    private static void UpdateItem()
    {
        Console.WriteLine("Enter the item name to update:");
        var name = Console.ReadLine().ToLower();

        var itemToUpdate = items.FirstOrDefault(x => x.Name == name);

        if (itemToUpdate == null)
        {
            Console.WriteLine("There is no such item in the inventory!");
            return;
        }

        Console.WriteLine($"Enter the new quantity for {itemToUpdate.Name}:");
        if (int.TryParse(Console.ReadLine(), out int newQuantity))
        {
            itemToUpdate.Quantity = newQuantity;
            Console.WriteLine($"{itemToUpdate.Name} quantity updated.");
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid quantity.");
        }
    }

    private static void RemoveItem()
    {
        Console.WriteLine("Enter the name of the item you want to remove from inventory:");
        var itemName = Console.ReadLine().ToLower();

        var itemToRemove = items.FirstOrDefault(x => x.Name == itemName);

        if (itemToRemove == null)
        {
            Console.WriteLine("There is no such item in the inventory!");
            return;
        }

        items.Remove(itemToRemove);
        Console.WriteLine($"{itemName} has been removed from the inventory.");
    }

    public static void ShowMenu()
    {
        StringBuilder st = new StringBuilder();
        st.AppendLine("Choose an option from the menu:");
        st.AppendLine("1. Add new item");
        st.AppendLine("2. List all items");
        st.AppendLine("3. Update item by name");
        st.AppendLine("4. Remove item");
        st.AppendLine("5. Exit");
        Console.WriteLine(st.ToString().TrimEnd());
    }
}