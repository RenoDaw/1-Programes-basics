namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Producte a mostra");
        var producte = "Cotxe";
        string nom_producte = "Audi";
        int preu = 30000;
        bool stock = false;
        Console.Write(producte + " " + nom_producte + " " + preu + " " + stock);
        
        
    }
}
