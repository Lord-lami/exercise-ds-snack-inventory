namespace SnackInventory;

// Your three methods. The comment above each one says what it should
// return, with examples. Replace each return line with your own code.
public static class Inventory
{
    /*
     * The snack with exactly this name (capital letters count), or null if
     * there isn't one. Return the snack itself, not a copy, so a change made
     * through it changes the snack in the list.
     *
     * FindSnack(snacks, "Trail Mix") -> the Trail Mix snack
     * FindSnack(snacks, "Popcorn") -> null
     */
    public static Snack? FindSnack(List<Snack> snacks, string name)
    {
        return null;
    }

    /*
     * What all the snacks' stock is worth together: the sum of their values.
     * No snacks at all are worth 0.
     *
     * TotalValue(the stand's four snacks) -> 138
     */
    public static int TotalValue(List<Snack> snacks)
    {
        return 0;
    }

    /*
     * The names of the snacks with fewer than `limit` left, in the order
     * they're in the list. A snack with exactly `limit` left isn't low.
     *
     * LowStock(snacks, 10) -> ["Trail Mix"]
     * LowStock(snacks, 16) -> ["Pretzel", "Trail Mix", "Apple Chips"]
     */
    public static List<string> LowStock(List<Snack> snacks, int limit)
    {
        return new List<string>();
    }
}
