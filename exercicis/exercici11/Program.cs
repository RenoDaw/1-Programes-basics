namespace exercici11;

// A partir de dues variables (nom d'usuari i domini), crea i imprimeix una adreça de correu electrònic completa.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercici nº11.");
        var nom_us = "jperarnau";
        var domini = "cendrassos.net";
        Console.WriteLine($"Dues variables {nom_us}, {domini}");
        string email = string.Concat(nom_us, "@", domini);
        Console.WriteLine($"L'adreça de correu electrònic es {email}");
    }
}
