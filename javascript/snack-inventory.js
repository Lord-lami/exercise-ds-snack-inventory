// The Snack class is ready except for its value method. Then finish the
// three functions below it. The comment above each one says what it should
// return, with examples. Replace each return line with your own code.

// One snack at the stand: its name, its price in whole dollars, and how many are left.
export class Snack {
  constructor(name, price, count) {
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
  value() {
    return 0;
  }
}

/*
 * The snack with exactly this name (capital letters count), or null if
 * there isn't one. Return the snack itself, not a copy, so a change made
 * through it changes the snack in the list.
 *
 * findSnack(snacks, "Trail Mix") -> the Trail Mix snack
 * findSnack(snacks, "Popcorn") -> null
 */
export function findSnack(snacks, name) {
  return null;
}

/*
 * What all the snacks' stock is worth together: the sum of their values.
 * No snacks at all are worth 0.
 *
 * totalValue(the stand's four snacks) -> 138
 */
export function totalValue(snacks) {
  return 0;
}

/*
 * The names of the snacks with fewer than `limit` left, in the order
 * they're in the list. A snack with exactly `limit` left isn't low.
 *
 * lowStock(snacks, 10) -> ["Trail Mix"]
 * lowStock(snacks, 16) -> ["Pretzel", "Trail Mix", "Apple Chips"]
 */
export function lowStock(snacks, limit) {
  return [];
}
