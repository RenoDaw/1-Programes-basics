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
            if (-1 != comaIndex)
            {
                int midaLlargada = totalLlargada - comaIndex;
                string reste = num_read.Substring(comaIndex, midaLlargada);
                Console.WriteLine($"Nombre meravellós: 0{reste}");
            }
            if (-1 == comaIndex)
            {
                // Ha fallat.
                Console.WriteLine("No procesable.");
            }
            Console.WriteLine();
            Console.WriteLine("Un altra solucio:");
            double numero = double.Parse(num_read);
            int resultado_nomia = (int)numero;
            double numEnter = resultado_nomia;
            double reste1 = numero - numEnter;
            Console.WriteLine($"Nombre meravellós: {reste1}");
            Console.WriteLine();
            Console.WriteLine("Un altra solucio:");
            double reste2 = Math.Truncate(numero);
            double reste3 = Math.Floor(numero);
            double result1 = numero - reste2;
            double result2 = numero - reste3;

            Console.WriteLine(reste2);
            Console.WriteLine(reste3);
            int midaLlargadaT = (totalLlargada - comaIndex) - 1;

            string numDecimals = midaLlargadaT.ToString();
            string fNumDecimals = $"F{numDecimals}";
            Console.WriteLine(fNumDecimals);
            Console.WriteLine($"{result1.ToString(fNumDecimals)}");
            Console.WriteLine($"{result2:F5}");
            Console.WriteLine();
            Console.WriteLine("Un altra solucio:");

            int midaLlargada2 = (totalLlargada - comaIndex) - 1;
            Console.WriteLine(midaLlargada2);
            double resultado = numero * Math.Pow(10, midaLlargada2);
            Console.WriteLine(resultado);
            double residuo = resultado % Math.Pow(10, midaLlargada2);
            int midaLlargada3 = (totalLlargada - comaIndex)-1;
            double resultat3 = residuo / Math.Pow(10, midaLlargada3);
            Console.WriteLine(residuo);
            Console.WriteLine($"Nombre meravellós: {resultat3}");

        }
        Console.WriteLine("Fi 1.");

        /* Console.WriteLine();
        int numdecimal = totalLlargada + 1;
        long denominador = 10 * numdecimal;
        long numeradorinicial = (long)(num_read * denominador);
        */

        
    }
}
