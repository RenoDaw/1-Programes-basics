namespace exercici13;

/* Un alumne ha inventat un sistema per codificar dates que consisteix a eliminar els separadors de les dates 
per fer no es vegi que són dates (la data 24/09/2024 la converteix en 24092024). 
El problema és que ho ha aplicat a tots els documents de l’institut i ara la direcció no sap 
ordenar els documents.

Necessitem un programa que faci el procés invers

Entra la data sense formatar: 25092024
La data és 25/09/2024

Entra la data sense formatar: 12031970
La data és 12/03/1970 */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercici nº13.");
        Console.WriteLine("Escriu la teva data en format numero");
        var num = Console.ReadLine();
        if (num != null)
        {
            string dia = num.Substring(0, 2);
            string mes = num.Substring(2, 2);
            string any = num.Substring(4, 4);
            Console.WriteLine($"La data es = {dia}/{mes}/{any}");
        }
        if (num == null)
        {
            Console.WriteLine("No operable");
        }
        Console.WriteLine("Fin.");
    }
}

