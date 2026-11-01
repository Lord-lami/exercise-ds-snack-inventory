// The tests for your code. You don't need to change this file.
// Each message says what was expected, so a failing test tells you what to look at.
import assert from "node:assert/strict";
import { test } from "node:test";
import { Snack, findSnack, lowStock, totalValue } from "./snack-inventory.ts";

function stand(): Snack[] {
  return [new Snack("Pretzel", 3, 12), new Snack("Granola Bar", 2, 20), new Snack("Trail Mix", 4, 8), new Snack("Apple Chips", 2, 15)];
}

test("value is the price times the count", () => {
  assert.equal(new Snack("Pretzel", 3, 12).value(), 36, "Not yet: 12 pretzels at $3 are worth $36.");
  assert.equal(new Snack("Trail Mix", 4, 8).value(), 32, "Not yet: 8 bags of trail mix at $4 are worth $32.");
  assert.equal(new Snack("Popcorn", 2, 0).value(), 0, "Not yet: a snack with none left is worth $0.");
});

test("find snack: finds a snack by its name", () => {
  const found = findSnack(stand(), "Trail Mix");
  assert.notEqual(found, null, "Not yet: Trail Mix is at the stand, so findSnack should return it, not null.");
  assert.equal(found!.name, "Trail Mix", "Not yet: findSnack(snacks, \"Trail Mix\") should return the Trail Mix snack.");
  assert.equal(found!.price, 4, "Not yet: the Trail Mix snack costs $4.");
});

test("find snack: gives the snack itself, not a copy", () => {
  const snacks = stand();
  const found = findSnack(snacks, "Pretzel");
  assert.notEqual(found, null, "Not yet: Pretzel is at the stand, so findSnack should return it, not null.");
  found!.count = 0;
  assert.equal(snacks[0].count, 0, "Not yet: return the snack from the list itself, so selling through it changes the list's snack.");
});

test("find snack: gives null when there is no such snack", () => {
  assert.notEqual(findSnack(stand(), "Apple Chips"), null, "Not yet: Apple Chips is at the stand, so findSnack should return it.");
  assert.equal(findSnack(stand(), "Popcorn"), null, "Not yet: there's no Popcorn at the stand, so findSnack should return null.");
  assert.equal(findSnack(stand(), "trail mix"), null, "Not yet: capital letters count, so \"trail mix\" isn't \"Trail Mix\": null.");
});

test("total value adds up every snack", () => {
  assert.equal(totalValue(stand()), 138, "Not yet: $36 + $40 + $32 + $30 = $138.");
  assert.equal(totalValue([]), 0, "Not yet: no snacks at all are worth $0.");
});

test("low stock lists the snacks under the limit, in order", () => {
  assert.deepEqual(lowStock(stand(), 10), ["Trail Mix"], "Not yet: only Trail Mix (8 left) has fewer than 10.");
  assert.deepEqual(lowStock(stand(), 16), ["Pretzel", "Trail Mix", "Apple Chips"], "Not yet: Pretzel (12), Trail Mix (8) and Apple Chips (15) have fewer than 16, in that order.");
});

test("low stock leaves out a snack right at the limit", () => {
  assert.deepEqual(lowStock(stand(), 12), ["Trail Mix"], "Not yet: Pretzel has exactly 12, which isn't fewer than 12, so only Trail Mix is low.");
});
