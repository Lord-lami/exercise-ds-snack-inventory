# The Snack class is ready except for its value method. Then finish the
# three functions below it. The comment under each one says what it should
# return, with examples. Replace each return line with your own code.


class Snack:
    """One snack at the stand: its name, its price in whole dollars, and how many are left."""

    def __init__(self, name, price, count):
        self.name = name
        self.price = price
        self.count = count

    def value(self):
        """
        What this snack's stock is worth: its price times how many are left.

        Snack("Pretzel", 3, 12).value() -> 36
        Snack("Trail Mix", 4, 0).value() -> 0
        """
        return self.price * self.count


def find_snack(snacks, name):
    """
    The snack with exactly this name (capital letters count), or None if
    there isn't one. Return the snack itself, not a copy, so a change made
    through it changes the snack in the list.

    find_snack(snacks, "Trail Mix") -> the Trail Mix snack
    find_snack(snacks, "Popcorn") -> None
    """
    for i, _ in enumerate(snacks):
        if snacks[i].name == name:
            return snacks[i]
    return None


def total_value(snacks):
    """
    What all the snacks' stock is worth together: the sum of their values.
    No snacks at all are worth 0.

    total_value(the stand's four snacks) -> 138
    """
    total = 0
    for s in snacks:
        total += s.value()
    return total


def low_stock(snacks, limit):
    """
    The names of the snacks with fewer than `limit` left, in the order
    they're in the list. A snack with exactly `limit` left isn't low.

    low_stock(snacks, 10) -> ["Trail Mix"]
    low_stock(snacks, 16) -> ["Pretzel", "Trail Mix", "Apple Chips"]
    """
    return [s.name for s in snacks if s.count < limit]
