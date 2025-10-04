namespace exercici18;

/* Un rellotger està perdent la memòria i necessita un programa que a partir de l'hora actual li puguem dir
 quina hora serà d’aquí un nombre determinat d’hores.

Hora actual: 9
Hores a incrementar: 3
D'aquí a 3 hores seran les 12


Hora actual: 11
Hores a incrementar: 3
D'aquí a 3 hores seran les 2
*/ 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercici nº. 18.");
        Console.Write("Escriu la hora Actual: ");
        var horaActuaLlegir = Console.ReadLine();
        if (horaActuaLlegir != null)
        {
            int numHoraActual = int.Parse(horaActuaLlegir);
            int increHoraActual = numHoraActual + 3;
            int restaAmPm = increHoraActual % 12;
            Console.WriteLine($"D'aqui a 3 hores seran les {restaAmPm}"); 
        }
        Console.WriteLine("Fi.");
    }
}
