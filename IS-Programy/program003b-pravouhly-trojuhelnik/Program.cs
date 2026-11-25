string again = "a";

while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("********************************");
    Console.WriteLine("***** Vykreslení trojuhelnik *****");
    Console.WriteLine("********************************");
    Console.WriteLine("********* Tomáš Žižka **********");
    Console.WriteLine("********************************");
    Console.WriteLine();

    // 1. Bezpečné načtení šířky s kontrolou na kladnou hodnotu
    Console.Write("Zadejte šířku trojuhelniku (přirozené číslo): ");
    int width;
    while (!int.TryParse(Console.ReadLine(), out width) || width <= 0)
    {
        Console.Write("Šířka musí být celé kladné číslo větší než 0. Zadejte znovu: ");
    }

    // 2. Bezpečné načtení výšky s kontrolou na kladnou hodnotu
    Console.Write("Zadejte výšku trojuhelniku (přirozené číslo): ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
    {
        Console.Write("Výška musí být celé kladné číslo větší než 0. Zadejte znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine($"Vykresluji trojuhelnik o rozměrech {width} × {height}:");
    Console.WriteLine();

   
    for (int i = 1; i <= height; i++)
    {
        // Vnitřní cyklus sází sloupce v aktuálním řádku (zleva doprava)
        if(i % 2 == 0)
        {

        Console.ForegroundColor = ConsoleColor.Green;

        }
        else
        {

        Console.ForegroundColor = ConsoleColor.Red;

        }
        for (int j = 1; j <= i;j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100)); // Efekt animace vykreslování
            
        }

        // Konec řádku -> přesun kurzoru na nový řádek
        Console.WriteLine();

       Console.ResetColor();
            
        
    }
     

    // 4. Dotaz na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte 'a' a potvrďte Enterem: ");
    again = Console.ReadLine() ?? "";
}