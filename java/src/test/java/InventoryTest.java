import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertNotNull;
import static org.junit.jupiter.api.Assertions.assertNull;

import java.util.List;
import org.junit.jupiter.api.Test;

// The tests for your code. You don't need to change this file.
// Each message says what was expected, so a failing test tells you what to look at.
class InventoryTest {
    private static List<Snack> stand() {
        return List.of(new Snack("Pretzel", 3, 12), new Snack("Granola Bar", 2, 20), new Snack("Trail Mix", 4, 8), new Snack("Apple Chips", 2, 15));
    }

    @Test
    void valueIsThePriceTimesTheCount() {
        assertEquals(36, new Snack("Pretzel", 3, 12).value(), "Not yet: 12 pretzels at $3 are worth $36.");
        assertEquals(32, new Snack("Trail Mix", 4, 8).value(), "Not yet: 8 bags of trail mix at $4 are worth $32.");
        assertEquals(0, new Snack("Popcorn", 2, 0).value(), "Not yet: a snack with none left is worth $0.");
    }

    @Test
    void findSnackFindsASnackByItsName() {
        Snack found = Inventory.findSnack(stand(), "Trail Mix");
        assertNotNull(found, "Not yet: Trail Mix is at the stand, so findSnack should return it, not null.");
        assertEquals("Trail Mix", found.name, "Not yet: findSnack(snacks, \"Trail Mix\") should return the Trail Mix snack.");
        assertEquals(4, found.price, "Not yet: the Trail Mix snack costs $4.");
    }

    @Test
    void findSnackGivesTheSnackItselfNotACopy() {
        List<Snack> stand = stand();
        Snack found = Inventory.findSnack(stand, "Pretzel");
        assertNotNull(found, "Not yet: Pretzel is at the stand, so findSnack should return it, not null.");
        found.count = 0;
        assertEquals(0, stand.get(0).count, "Not yet: return the snack from the list itself, so selling through it changes the list's snack.");
    }

    @Test
    void findSnackGivesNullWhenThereIsNoSuchSnack() {
        assertNotNull(Inventory.findSnack(stand(), "Apple Chips"), "Not yet: Apple Chips is at the stand, so findSnack should return it.");
        assertNull(Inventory.findSnack(stand(), "Popcorn"), "Not yet: there's no Popcorn at the stand, so findSnack should return null.");
        assertNull(Inventory.findSnack(stand(), "trail mix"), "Not yet: capital letters count, so \"trail mix\" isn't \"Trail Mix\": null.");
    }

    @Test
    void totalValueAddsUpEverySnack() {
        assertEquals(138, Inventory.totalValue(stand()), "Not yet: $36 + $40 + $32 + $30 = $138.");
        assertEquals(0, Inventory.totalValue(List.of()), "Not yet: no snacks at all are worth $0.");
    }

    @Test
    void lowStockListsTheSnacksUnderTheLimitInOrder() {
        assertEquals(List.of("Trail Mix"), Inventory.lowStock(stand(), 10), "Not yet: only Trail Mix (8 left) has fewer than 10.");
        assertEquals(List.of("Pretzel", "Trail Mix", "Apple Chips"), Inventory.lowStock(stand(), 16),
            "Not yet: Pretzel (12), Trail Mix (8) and Apple Chips (15) have fewer than 16, in that order.");
    }

    @Test
    void lowStockLeavesOutASnackRightAtTheLimit() {
        assertEquals(List.of("Trail Mix"), Inventory.lowStock(stand(), 12),
            "Not yet: Pretzel has exactly 12, which isn't fewer than 12, so only Trail Mix is low.");
    }
}
