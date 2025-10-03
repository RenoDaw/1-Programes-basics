namespace exercici6;

/* Declara una variable per al costat d'un quadrat. Calcula el seu perímetre (suma dels quatre costats) 
i imprimeix-lo. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercici nº6.");
        const double costat = 3.5;
        Console.WriteLine($"Mida del costat del quadrat {costat}");
        double perimetre = costat * 4;
        Console.WriteLine($"El perimetre {perimetre}");
    }
}
