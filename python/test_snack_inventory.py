# The tests for your code. You don't need to change this file.
# Each message says what was expected, so a failing test tells you what to look at.
from snack_inventory import Snack, find_snack, low_stock, total_value


def stand():
    return [Snack("Pretzel", 3, 12), Snack("Granola Bar", 2, 20), Snack("Trail Mix", 4, 8), Snack("Apple Chips", 2, 15)]


def test_value_is_the_price_times_the_count():
    assert Snack("Pretzel", 3, 12).value() == 36, "Not yet: 12 pretzels at $3 are worth $36."
    assert Snack("Trail Mix", 4, 8).value() == 32, "Not yet: 8 bags of trail mix at $4 are worth $32."
    assert Snack("Popcorn", 2, 0).value() == 0, "Not yet: a snack with none left is worth $0."


def test_find_snack_finds_a_snack_by_its_name():
    found = find_snack(stand(), "Trail Mix")
    assert found is not None, "Not yet: Trail Mix is at the stand, so find_snack should return it, not None."
    assert found.name == "Trail Mix", "Not yet: find_snack(snacks, \"Trail Mix\") should return the Trail Mix snack."
    assert found.price == 4, "Not yet: the Trail Mix snack costs $4."


def test_find_snack_gives_the_snack_itself_not_a_copy():
    snacks = stand()
    found = find_snack(snacks, "Pretzel")
    assert found is not None, "Not yet: Pretzel is at the stand, so find_snack should return it, not None."
    found.count = 0
    assert snacks[0].count == 0, "Not yet: return the snack from the list itself, so selling through it changes the list's snack."


def test_find_snack_gives_none_when_there_is_no_such_snack():
    assert find_snack(stand(), "Apple Chips") is not None, "Not yet: Apple Chips is at the stand, so find_snack should return it."
    assert find_snack(stand(), "Popcorn") is None, "Not yet: there's no Popcorn at the stand, so find_snack should return None."
    assert find_snack(stand(), "trail mix") is None, "Not yet: capital letters count, so \"trail mix\" isn't \"Trail Mix\": None."


def test_total_value_adds_up_every_snack():
    assert total_value(stand()) == 138, "Not yet: $36 + $40 + $32 + $30 = $138."
    assert total_value([]) == 0, "Not yet: no snacks at all are worth $0."


def test_low_stock_lists_the_snacks_under_the_limit_in_order():
    assert low_stock(stand(), 10) == ["Trail Mix"], "Not yet: only Trail Mix (8 left) has fewer than 10."
    assert low_stock(stand(), 16) == ["Pretzel", "Trail Mix", "Apple Chips"], \
        "Not yet: Pretzel (12), Trail Mix (8) and Apple Chips (15) have fewer than 16, in that order."


def test_low_stock_leaves_out_a_snack_right_at_the_limit():
    assert low_stock(stand(), 12) == ["Trail Mix"], "Not yet: Pretzel has exactly 12, which isn't fewer than 12, so only Trail Mix is low."
