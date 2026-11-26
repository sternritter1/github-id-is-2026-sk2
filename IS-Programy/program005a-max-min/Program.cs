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

    int max = numbers[0];
    int min = numbers[0];
    int posMax = 0;
    int posMin = 0;
    
    for(int i = 0;i < count; i++)
{
    if(numbers[i] > max)
    {
        max = numbers[i];
        posMax = i;
    }
    if(numbers[i] < min)
    {
        min = numbers[i];
        posMin = i;
    }
}
Console.WriteLine($"Maximum: {max}");
Console.WriteLine($"Pos Maximum: {posMax}");
Console.WriteLine($"Minimum: {min}");
Console.WriteLine($"Pos Min: {posMin}");

    if(max >= 3)
    {
        for(int i = 0;i < max; i++)
        {
            int spaces = 0;
            int stars = 0;

            if(i < max / 2)
            {
                spaces = i;
                stars = max - (2 * i);
            }
            else
            {
                spaces = max - 1 - i;
                stars = max - 2 * (max - 1 - i);
            }

            for(int sp = 0;sp < spaces; sp++)
        {
            Console.Write(" ");
        }

            for(int st = 0;st < stars; st++)
        {
            Console.Write("*");
        }
        
        Console.WriteLine();
        }
    }