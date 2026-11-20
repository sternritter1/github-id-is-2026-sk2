Console.Write("Zadejte celé číslo: ");
long n = Math.Abs(long.Parse(Console.ReadLine()!));
long zbytek = n;

long soucet = 0;
long soucin = 1;

do
{
    long cifra = zbytek % 10;
    soucet += cifra;
    soucin *= cifra;
    zbytek /= 10;
} while (zbytek > 0);

Console.WriteLine($"Ciferný součet čísla {n} je {soucet}");
Console.WriteLine($"Ciferný součin čísla {n} je {soucin}");