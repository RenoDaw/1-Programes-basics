namespace exercici8;

/* Assigna un nombre total de minuts a una variable. 
Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercici nº8");
        const int Minuts = 65874;
        Console.WriteLine($"Minuts a calcular {Minuts} en horas");
        int hores = Minuts / 60;
        int Minuts_resta = Minuts % 60;
        Console.WriteLine($"Son {hores} hores mes {Minuts_resta} Minuts. ");
    }
}
