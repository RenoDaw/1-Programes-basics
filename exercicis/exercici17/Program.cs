namespace exercici17;

/* Hi ha una secta d’adoradors dels decimals que volen que els hi feu un programa que a partir d’un nombre real, 
ex. 4.56, només ens retorni els decimals, 0,56. Als números que només tenen decimals els anomenen “nombres meravellosos”

Número lleig: 23,45
Nombre meravellós: 0,45


Número lleig: 8,5
Nombre meravellós: 0,5
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exertcici nº. 17.");
        Console.Write("Escriu Un numero amb decimals: ");
        var num_read = Console.ReadLine();
        if (num_read != null)
        {
            int comaIndex = num_read.IndexOf(",");
            int totalLlargada = num_read.Length;
            if (-1 != comaIndex){
                int midaLlargada = totalLlargada - comaIndex;
                string reste = num_read.Substring(comaIndex, midaLlargada);
                Console.WriteLine($"Nombre meravellós: 0{reste}");
            }
            if (-1 == comaIndex)
            {
                // Ha fallat.
                Console.WriteLine("No procesable.");
            }
        }
        Console.WriteLine("Fi.");
    }
}
