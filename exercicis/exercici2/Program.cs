namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercici nº2:");
        Console.WriteLine("Entra el nom del carrer:");
        var nom = Console.ReadLine(); 
        Console.WriteLine("Entra el numero carrer:");
        var numero = Console.ReadLine();
        Console.WriteLine("Entra el codic postal:");
        var codic = Console.ReadLine();
        Console.WriteLine("Entra nom de la població:");
        var poblacio = Console.ReadLine();
        Console.WriteLine($"El carrer {nom}, amb numero {numero}, C.P.: {codic}, a {poblacio}.");

    }
}
