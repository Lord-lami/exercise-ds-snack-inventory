# Exercise: The Snack Inventory

Exercise code for the lesson **Exercise: The Snack Inventory** in the course *Data Structures and Big-O, Demystified* on [ask-codey.com](https://www.ask-codey.com).

A snack stand keeps each snack as an object: its name, its price in whole dollars, and how many are left. You'll finish the `Snack` class and write the stand's inventory code, using the loops, lists, classes and references from *The Code You Need*. There are four pieces to finish:

- the `value` method on `Snack` (`Value` in C#): what one snack's stock is worth
- `findSnack` (`FindSnack` in C#, `find_snack` in Python): the snack with a given name, or nothing
- `totalValue` (`TotalValue`, `total_value`): what all the stock is worth together
- `lowStock` (`LowStock`, `low_stock`): the names of the snacks running low

## Pick your language

The same exercise is here in five languages. Work in the folder for the language you set up; you only need one.

| Folder | Your code | The tests |
|---|---|---|
| `csharp/` | `SnackInventory/Snack.cs` and `SnackInventory/Inventory.cs` | `SnackInventory.Tests/InventoryTests.cs` |
| `java/` | `src/main/java/Snack.java` and `src/main/java/Inventory.java` | `src/test/java/InventoryTest.java` |
| `python/` | `snack_inventory.py` | `test_snack_inventory.py` |
| `javascript/` | `snack-inventory.js` | `snack-inventory.test.js` |
| `typescript/` | `snack-inventory.ts` | `snack-inventory.test.ts` |

Each piece returns `0`, nothing (`null` or `None`) or an empty list for now. The comment with it says what it should return, with examples. Replace the `return` line with your own code.

Every folder also has a small demo program that tries your code on the snack stand. You don't need to change the tests or the demo.

## Run it and check your work

Open your language's folder in VS Code (**File > Open Folder**), then open its terminal (**Terminal > New Terminal**) and run these commands there.

**C#**

```bash
dotnet run --project SnackInventory
dotnet test
```

**Java** (the Maven Wrapper downloads Maven the first time, so the first run takes a minute)

```bash
java src/main/java/Demo.java
./mvnw test
```

On Windows in PowerShell, write `.\mvnw test` instead of `./mvnw test`.

**Python** (once: make a virtual environment and install pytest into it)

```bash
python -m venv .venv
```

Then turn it on: `.venv\Scripts\Activate.ps1` in PowerShell on Windows, or `source .venv/bin/activate` on macOS (where the command is `python3`, not `python`). Then:

```bash
pip install -r requirements.txt
python demo.py
python -m pytest
```

**JavaScript**

```bash
node demo.js
npm test
```

**TypeScript** (once: `npm install`, which installs TypeScript)

```bash
node demo.ts
npm test
```

At first every test fails: that is expected. Each piece you finish turns its tests green. A failing test's message starts with **Not yet:** and says what it expected.

## Tips

- **Start with `value`.** It's one line, and `totalValue` uses it.
- **Return the snack itself.** `findSnack` hands back the object from the list, not a new one, so a change made through it reaches the list (*References: Two Names, One Object*).
- **No match means nothing.** If the loop ends without finding the name, return `null` (`None` in Python).
- **Fewer than means fewer than.** A snack with exactly the limit left isn't low.

## Hand it in

When it works, push your solution to a public repo of your own on GitHub, then paste that repo's address into **Submit your exercise** on the lesson page at [ask-codey.com](https://www.ask-codey.com). That's what completes the lesson. The lesson page shows the Git commands, step by step.
