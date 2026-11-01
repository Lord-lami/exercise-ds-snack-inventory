// One snack at the stand: its name, its price in whole dollars, and how
// many are left. The fields and the constructor are ready to use; finish
// the value method.
public class Snack {
    public String name;
    public int price;
    public int count;

    public Snack(String name, int price, int count) {
        this.name = name;
        this.price = price;
        this.count = count;
    }

    /*
     * What this snack's stock is worth: its price times how many are left.
     *
     * new Snack("Pretzel", 3, 12).value() -> 36
     * new Snack("Trail Mix", 4, 0).value() -> 0
     */
    public int value() {
        return 0;
    }
}
