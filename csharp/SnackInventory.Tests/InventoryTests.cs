using SnackInventory;

namespace SnackInventory.Tests;

// The tests for your code. You don't need to change this file.
// Each message says what was expected, so a failing test tells you what to look at.

[TestClass]
public class InventoryTests
{
    private static List<Snack> Stand() => new List<Snack> { new Snack("Pretzel", 3, 12), new Snack("Granola Bar", 2, 20), new Snack("Trail Mix", 4, 8), new Snack("Apple Chips", 2, 15) };

    [TestMethod]
    public void ValueIsThePriceTimesTheCount()
    {
        Assert.AreEqual(36, new Snack("Pretzel", 3, 12).Value(), "Not yet: 12 pretzels at $3 are worth $36.");
        Assert.AreEqual(32, new Snack("Trail Mix", 4, 8).Value(), "Not yet: 8 bags of trail mix at $4 are worth $32.");
        Assert.AreEqual(0, new Snack("Popcorn", 2, 0).Value(), "Not yet: a snack with none left is worth $0.");
    }

    [TestMethod]
    public void FindSnackFindsASnackByItsName()
    {
        Snack? found = Inventory.FindSnack(Stand(), "Trail Mix");
        Assert.IsNotNull(found, "Not yet: Trail Mix is at the stand, so FindSnack should return it, not null.");
        Assert.AreEqual("Trail Mix", found.Name, "Not yet: FindSnack(snacks, \"Trail Mix\") should return the Trail Mix snack.");
        Assert.AreEqual(4, found.Price, "Not yet: the Trail Mix snack costs $4.");
    }

    [TestMethod]
    public void FindSnackGivesTheSnackItselfNotACopy()
    {
        List<Snack> stand = Stand();
        Snack? found = Inventory.FindSnack(stand, "Pretzel");
        Assert.IsNotNull(found, "Not yet: Pretzel is at the stand, so FindSnack should return it, not null.");
        found.Count = 0;
        Assert.AreEqual(0, stand[0].Count, "Not yet: return the snack from the list itself, so selling through it changes the list's snack.");
    }

    [TestMethod]
    public void FindSnackGivesNullWhenThereIsNoSuchSnack()
    {
        Assert.IsNotNull(Inventory.FindSnack(Stand(), "Apple Chips"), "Not yet: Apple Chips is at the stand, so FindSnack should return it.");
        Assert.IsNull(Inventory.FindSnack(Stand(), "Popcorn"), "Not yet: there's no Popcorn at the stand, so FindSnack should return null.");
        Assert.IsNull(Inventory.FindSnack(Stand(), "trail mix"), "Not yet: capital letters count, so \"trail mix\" isn't \"Trail Mix\": null.");
    }

    [TestMethod]
    public void TotalValueAddsUpEverySnack()
    {
        Assert.AreEqual(138, Inventory.TotalValue(Stand()), "Not yet: $36 + $40 + $32 + $30 = $138.");
        Assert.AreEqual(0, Inventory.TotalValue(new List<Snack>()), "Not yet: no snacks at all are worth $0.");
    }

    [TestMethod]
    public void LowStockListsTheSnacksUnderTheLimitInOrder()
    {
        CollectionAssert.AreEqual(new List<string> { "Trail Mix" }, Inventory.LowStock(Stand(), 10), "Not yet: only Trail Mix (8 left) has fewer than 10.");
        CollectionAssert.AreEqual(new List<string> { "Pretzel", "Trail Mix", "Apple Chips" }, Inventory.LowStock(Stand(), 16),
            "Not yet: Pretzel (12), Trail Mix (8) and Apple Chips (15) have fewer than 16, in that order.");
    }

    [TestMethod]
    public void LowStockLeavesOutASnackRightAtTheLimit()
    {
        CollectionAssert.AreEqual(new List<string> { "Trail Mix" }, Inventory.LowStock(Stand(), 12),
            "Not yet: Pretzel has exactly 12, which isn't fewer than 12, so only Trail Mix is low.");
    }
}
