import java.util.ArrayList;
import java.util.List;

// Tries your code on the snack stand. Run it with: java src/main/java/Demo.java
public class Demo {
    public static void main(String[] args) {
        List<Snack> snacks = List.of(new Snack("Pretzel", 3, 12), new Snack("Granola Bar", 2, 20), new Snack("Trail Mix", 4, 8), new Snack("Apple Chips", 2, 15));

        List<String> names = new ArrayList<>();
        for (Snack snack : snacks) {
            names.add(snack.name);
        }
        System.out.println("Snacks: " + String.join(", ", names));
        System.out.println("Trail Mix is worth: $" + snacks.get(2).value());
        Snack chips = Inventory.findSnack(snacks, "Apple Chips");
        System.out.println("Found: " + (chips == null ? "nothing" : chips.name + ", $" + chips.price + ", " + chips.count + " left"));
        System.out.println("Popcorn found? " + (Inventory.findSnack(snacks, "Popcorn") == null ? "no" : "yes"));
        System.out.println("Total value: $" + Inventory.totalValue(snacks));
        System.out.println("Low stock (under 10): " + String.join(", ", Inventory.lowStock(snacks, 10)));
    }
}
