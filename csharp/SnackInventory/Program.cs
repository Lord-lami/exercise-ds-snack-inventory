using SnackInventory;

// Tries your code on the snack stand. Run it with: dotnet run --project SnackInventory
List<Snack> snacks = new List<Snack> { new Snack("Pretzel", 3, 12), new Snack("Granola Bar", 2, 20), new Snack("Trail Mix", 4, 8), new Snack("Apple Chips", 2, 15) };

List<string> names = new List<string>();
foreach (Snack snack in snacks)
{
    names.Add(snack.Name);
}
Console.WriteLine("Snacks: " + string.Join(", ", names));
Console.WriteLine("Trail Mix is worth: $" + snacks[2].Value());
Snack? chips = Inventory.FindSnack(snacks, "Apple Chips");
Console.WriteLine("Found: " + (chips == null ? "nothing" : chips.Name + ", $" + chips.Price + ", " + chips.Count + " left"));
Console.WriteLine("Popcorn found? " + (Inventory.FindSnack(snacks, "Popcorn") == null ? "no" : "yes"));
Console.WriteLine("Total value: $" + Inventory.TotalValue(snacks));
Console.WriteLine("Low stock (under 10): " + string.Join(", ", Inventory.LowStock(snacks, 10)));
