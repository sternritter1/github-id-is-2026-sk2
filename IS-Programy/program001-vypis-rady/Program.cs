
int ReadInt(string name)
{
    while (true)
    {
        Console.Write($"Enter {name}: ");
        if (int.TryParse(Console.ReadLine(), out int value))
            return value;
        Console.WriteLine("Invalid input, please enter a whole number.");
    }
}

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("=== Number sequence ===");

    int first = ReadInt("first");
    int last = ReadInt("last");
    int step = ReadInt("step");
    while (step <= 0)
    {
        Console.WriteLine("Step must be greater than 0.");
        step = ReadInt("step");
    }

    Console.WriteLine();
    for (int i = first; i <= last; i += step)
        Console.WriteLine(i);

    Console.WriteLine();
    Console.Write("Run again? (a = yes, anything else = exit): ");
    again = Console.ReadLine() ?? "";
}