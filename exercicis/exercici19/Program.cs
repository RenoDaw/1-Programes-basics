namespace exercici19;

// Assigna una paraula a una variable de text. Utilitza una funció per a obtenir la seva longitud i 
// imprimeix la paraula i el seu nombre de caràcters.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercici nº. 19.");
        Console.Write("Escriu una paraula: ");
        var paraulaLlegir = Console.ReadLine();
        if (paraulaLlegir != null)
        {
            string paraula = $"{paraulaLlegir}";
            int totalCaracter = paraulaLlegir.Length;
            Console.WriteLine($"La teva paraula es '{paraula}' i conté {totalCaracter} caràcters.");
        }
        Console.WriteLine("Fi.");
    }
}
