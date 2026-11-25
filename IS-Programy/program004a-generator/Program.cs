
Console.Write("Zadej pocet cisel(cele cislo): ");
    int count;
    while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
    {
        Console.Write("Pocet cisel musi byt v celych cislech a vyssi nez 0.Zadejte znovu: ");
    }
 Console.Write("Zadej nejmensi cislo(cele cislo): ");
    int lower;
    while (!int.TryParse(Console.ReadLine(), out lower))
    {
        Console.Write("Nejnizsi cislo musi byt celim.Zadejte znovu: ");
    }
 Console.Write("Zadej nejvyssi cislo(cele cislo): ");
    int upper;
    while (!int.TryParse(Console.ReadLine(), out upper) || upper <= lower)
    {
        Console.Write("Nejsvyssi cislo musi byt celim a vetsim nez nejnizsi.Zadejte znovu: ");
    }

    int[] numbers = new int [count];
    Random rnd = new Random();

    for(int i = 0;i < count;i++)
{
    numbers[i] = rnd.Next(lower,upper + 1);
    Console.Write(numbers[i] + " ");
    
}
Console.WriteLine();

    int zapornych = 0;
    int kladnych = 0;
    int nulovych = 0;
    int sudych = 0;
    int lichych = 0;
    for(int i = 0;i < count; i++)
{
   if(numbers[i] < 0)
    {
        zapornych++;
    }
    else if(numbers[i] > 0)
    {
        kladnych++;
    }
    else
    {
        nulovych++;
    }

    if(numbers[i] % 2 == 1 || numbers[i] % 2 == -1)
    {
        lichych++;
    }
    else
    {
        sudych++;
    }
}

Console.WriteLine($"Zapornych cisel je: {zapornych}");
Console.WriteLine($"Kladnych cisel je: {kladnych}");
Console.WriteLine($"Nulovych cisel je: {nulovych}");
Console.WriteLine($"sudych cisel je: {sudych}");
Console.WriteLine($"lichych cisel je: {lichych}");




