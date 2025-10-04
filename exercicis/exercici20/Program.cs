namespace exercici20;

/* Ens cal un programa que quan li entrem un número de tres xifres i ens retorni 
el número amb els dígits invertits. 

Ex. 245 -> 542
Entra el número a invertir: 347
El número invertit és: 743
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercici nº. 20.");
        Console.Write("Escriu un número de tres xifres: ");
        int numero;
        var text = Console.ReadLine();
        bool ok = int.TryParse(text, out numero);
        if (!ok)
        {
            //Ha Fallat
            Console.WriteLine("No operable.");
        }
        string numeroCadena = numero.ToString();
        char a = numeroCadena[0];
        char b = numeroCadena[1];
        char c = numeroCadena[2];
        string invertiCadena = $"{c}{b}{a}";
        Console.WriteLine($"El número invertit és: {invertiCadena}");
        Console.WriteLine("Fi.");
    }
}
