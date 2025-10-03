namespace exercici12;

/* Fes un programa que a partir de dos números imprimeixi per pantalla la seva suma, la seva resta, 
la seva multiplicació i la seva divisió

Entra el primer número: 3
Entra el segon número: 4

4 + 3 = 7
4 - 3 = 1
4 * 5 = 12
4 / 3 = 1  i en sobra 1


Entra el primer número: 25
Entra el segon número: 5

25 + 5 = 30
25 - 5 = 20
25 * 5 = 125
25 / 5 = 5  i en sobra 0
*/



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercici nº.12");
        Console.WriteLine("Escriu un primer numero i enter!!");
        var primer_numero = Console.ReadLine();
        Console.WriteLine("Escriu un segon numero i enter!!");
        var segon_numero = Console.ReadLine();
        bool ok1 = int.TryParse(primer_numero, out int primer_numero_valid);
        bool ok2 = int.TryParse(segon_numero, out int segon_numero_valid);
        bool ok = ok1 && ok2;
        if (!ok)
        {
            // Ha fallat
            Console.WriteLine("Error necessito números has posat lletres....");
            Console.WriteLine("Torna a ejecutar el 'dotnet run' ");
        }
        if (ok)
        {
            // Es correcta
            Console.WriteLine($"Valores correcte {primer_numero}, {primer_numero_valid}, {ok1}. ");
            Console.WriteLine($"Valores correcte {segon_numero}, {segon_numero_valid}, {ok}. ");
            Console.WriteLine($"La suma dels dos numeros es {primer_numero_valid + segon_numero_valid}");
            Console.WriteLine($"La resta dels dos numeros es {primer_numero_valid - segon_numero_valid}");
            Console.WriteLine($"La multiplicació dels dos numeros es {primer_numero_valid * segon_numero_valid}");
            Console.WriteLine($"La divisio dels dos numeros es {primer_numero_valid / segon_numero_valid}");
            Console.WriteLine($"El sobran de la divisio es {primer_numero_valid % segon_numero_valid}");

        }



    }
}
