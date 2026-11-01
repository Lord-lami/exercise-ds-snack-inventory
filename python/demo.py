# Tries your code on the snack stand. Run it with: python demo.py
from snack_inventory import Snack, find_snack, low_stock, total_value

snacks = [Snack("Pretzel", 3, 12), Snack("Granola Bar", 2, 20), Snack("Trail Mix", 4, 8), Snack("Apple Chips", 2, 15)]

print("Snacks: " + ", ".join(snack.name for snack in snacks))
print(f"Trail Mix is worth: ${snacks[2].value()}")
chips = find_snack(snacks, "Apple Chips")
print("Found: " + ("nothing" if chips is None else f"{chips.name}, ${chips.price}, {chips.count} left"))
print("Popcorn found? " + ("no" if find_snack(snacks, "Popcorn") is None else "yes"))
print(f"Total value: ${total_value(snacks)}")
print("Low stock (under 10): " + ", ".join(low_stock(snacks, 10)))
