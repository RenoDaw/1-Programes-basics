namespace exercici5;

/* Feu un programa que demani un nom i l’any de naixement i
 imprimeixi per pantalla 
“Hola [nom]!  Ja tens [edat] anys? 
nom i edat seran el nom introduït i 
l'edat la resta de l’any actual i l’any de naixement. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercici Nº5.");
        Console.WriteLine("Hola!!");
        Console.WriteLine("Com et diu?");
        var nom = Console.ReadLine();
        Console.WriteLine("En quin any vas neixer?");
        var any_naix = Console.ReadLine();
        // int any_numero = int.Parse(any_naix);
        bool ok = int.TryParse(any_naix, out int any_naix_vali);
        if (!ok)
        {
            // Ha fallat
            Console.WriteLine("Error necessito números has posat lletres....");
            Console.WriteLine("Torna a ejecutar el 'dotnet run' ");
        }
        if (ok)
        {
            // Es correcta
            const int any_actual = 2025;
            int edat_actual = any_actual - any_naix_vali;
            Console.WriteLine($" Hola {nom}! Ja tens {edat_actual} anys? ");

        }
        // int edat_actual_P = any_actual - any_numero;
        //Console.WriteLine($"Amb metode 'Parse'. Hola {nom}! Ja tens {edat_actual_P}?  ");
   }
}
