// Tries your code on the snack stand. Run it with: node demo.ts
import { Snack, findSnack, lowStock, totalValue } from "./snack-inventory.ts";

const snacks: Snack[] = [new Snack("Pretzel", 3, 12), new Snack("Granola Bar", 2, 20), new Snack("Trail Mix", 4, 8), new Snack("Apple Chips", 2, 15)];

console.log("Snacks: " + snacks.map((snack) => snack.name).join(", "));
console.log(`Trail Mix is worth: $${snacks[2].value()}`);
const chips = findSnack(snacks, "Apple Chips");
console.log("Found: " + (chips === null ? "nothing" : `${chips.name}, $${chips.price}, ${chips.count} left`));
console.log("Popcorn found? " + (findSnack(snacks, "Popcorn") === null ? "no" : "yes"));
console.log(`Total value: $${totalValue(snacks)}`);
console.log("Low stock (under 10): " + lowStock(snacks, 10).join(", "));
