namespace SnackInventory;

// One snack at the stand: its name, its price in whole dollars, and how
// many are left. The fields and the constructor are ready to use; finish
// the Value method.
public class Snack
{
    public string Name;
    public int Price;
    public int Count;

    public Snack(string name, int price, int count)
    {
        Name = name;
        Price = price;
        Count = count;
    }

    /*
     * What this snack's stock is worth: its price times how many are left.
     *
     * new Snack("Pretzel", 3, 12).Value() -> 36
     * new Snack("Trail Mix", 4, 0).Value() -> 0
     */
    public int Value()
    {
        return 0;
    }
}
