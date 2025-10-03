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
        //string num;
        Console.Write("Número lleig: ");
        var num_read = Console.ReadLine();
        if (num_read != null)
        { 
            int jk = num_read.IndexOf(",");
            string resultado = 
            Console.WriteLine($" rer {jk}");
        }
        if (num_read == null)
        {
            // Ha fallat
            Console.WriteLine("No tengo datos.");
        }
        Console.WriteLine("Fi.");
        
            //double result = num % 1;
        //int retorn = (int)num;
        //float retorn2 = (float) retorn;
        //float result = num - retorn2;
        //double result2 = Math.Round(result);
        //Console.WriteLine($"Nombre meravellós: {result} n {num}");
            

        
        Console.WriteLine("Fi.");

    }
}
