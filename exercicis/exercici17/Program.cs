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
        Console.WriteLine();
        Console.WriteLine("Exertcici nº. 17.");
        Console.WriteLine();
        Console.Write("Escriu Un numero amb decimals: ");
        var num_read = Console.ReadLine();
        if (num_read != null)
        {
            int comaIndex = num_read.IndexOf(",");
            int totalLlargada = num_read.Length;
            if (-1 != comaIndex)
            {
                int midaLlargada = totalLlargada - comaIndex;
                string partDecimal = num_read.Substring(comaIndex, midaLlargada);
                Console.WriteLine($"Nombre meravellós: 0{partDecimal}");

                Console.WriteLine();
                Console.WriteLine("Un altra solucio:");
                Console.WriteLine("Segona metode ");
                Console.WriteLine("amb double.Parse(String) Convierte una representacio en cadena de texto en su valor numerico");
                Console.WriteLine("amb (int) Conversión Explícita o Cast (Moldeado)");
                
                double numero = double.Parse(num_read);
                int parteEnteraB = (int)numero;
                double partEnteraFormat = parteEnteraB;
                double partDecimalB = numero - partEnteraFormat;
                Console.WriteLine($"Nombre meravellós: {partDecimalB} format numero.");
                Console.WriteLine();
                int midaLlargadaTB = (totalLlargada - comaIndex) - 1;
                string numDecimalsB = midaLlargadaTB.ToString();
                string fNumDecimalsB = $"F{numDecimalsB}";
                Console.WriteLine($"Nombre meravellós: {partDecimalB.ToString(fNumDecimalsB)} format String");
 

                Console.WriteLine();
                Console.WriteLine("Un altra solucio:");
                Console.WriteLine("Tercer Metode");
                Console.WriteLine("amb Math.Truncante  Es una función matemática. Devuelve la parte entera, ");
                Console.WriteLine("pero mantiene el tipo de dato original (double o decimal).");
                Console.WriteLine();
                double parteEntereC = Math.Truncate(numero);
                double partDecimalC = numero - parteEntereC;
                Console.WriteLine($"Nombre meravellós: {partDecimalC} format numero.");
                Console.WriteLine();
                int midaLlargadaTC = (totalLlargada - comaIndex) - 1;
                string numDecimalsC = midaLlargadaTC.ToString();
                string fNumDecimalsC = $"F{numDecimalsC}";
                Console.WriteLine($"Nombre meravellós: {partDecimalC.ToString(fNumDecimalsC)}");
               

                Console.WriteLine();
                
                Console.WriteLine("Un altra solucio:");
                Console.WriteLine("Quart Metode");
                Console.WriteLine("amb amb Poencia de 10. Math.Pow  Es una función matemática. ");
                Console.WriteLine("C# s'utilitza per calcular la potència d'un nombre.");
                
                int numeroDecimalsD = (totalLlargada - comaIndex) - 1;
                double numeroEnter = numero * Math.Pow(10, numeroDecimalsD);
                double residu = numeroEnter % Math.Pow(10, numeroDecimalsD);
                double partDecimalD = residu / Math.Pow(10, numeroDecimalsD);
                Console.WriteLine();
                Console.WriteLine($"Nombre meravellós: {partDecimalD}");





            }
            if (-1 == comaIndex)
            {
                // Ha fallat.
                Console.WriteLine("No procesable.");
            }
            

        }
        Console.WriteLine("Fi.");

        /* Console.WriteLine();
        int numdecimal = totalLlargada + 1;
        long denominador = 10 * numdecimal;
        long numeradorinicial = (long)(num_read * denominador);
        */

        
    }
}
