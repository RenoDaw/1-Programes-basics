namespace exercici15;

// Assigna un nom i un cognom en variables. Imprimeix el nom complet, 
// assegurant-te que la primera lletra de cada paraula estigui en majúscula
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercici nº15");
        var nom = "pere";
        var cognom = "castanys";
        char lletra1 = nom[0];
        char lletra2 = cognom[0];
        string C1 = lletra1.ToString();
        string C2 = lletra2.ToString();
        string m1 = C1.ToUpper();
        string m2 = C2.ToUpper();
        Console.WriteLine($"{m1}ere {m2}astany ");
    }
}
