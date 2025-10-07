namespace exercici16;

/* Ningú entén res del nou sistema d’avaluació. Necessitem un programa que calculi la part que és més senzilla: 
a partir de la mitjana de les notes les pràctiques i la nota de l’examen ens calculi la nota final

Nota de pràctiques: 8 (40%)
Nota de l’examen: 9   (60%)
La nota final és 8.7 o sigui un 9

*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Erxercici nº. 16.");

        int Nota_p_num;
        Console.Write("Nota de pràctiques: ");
        var Nota_p = Console.ReadLine();
        int Nota_e_num;
        Console.Write("Nota de l'examen: ");
        var Nota_e = Console.ReadLine();
        bool ok_p = int.TryParse(Nota_p, out Nota_p_num);
        bool ok_e = int.TryParse(Nota_e, out Nota_e_num);
        bool ok = ok_p && ok_e;
        if (!ok)
        {
            // Ha fallat
            Console.WriteLine("No son notes validas ...necesito numeros");
        }
        if (ok)
        {
            double Nota_p_num_deci = Nota_p_num;
            double Nota_e_num_deci = Nota_e_num;
            double resul = (Nota_p_num_deci + Nota_e_num_deci) / 2.0;
            int Coefi = (int) resul;
            Console.WriteLine($"La nota final es {resul} o sigui {Coefi} ");
        }
        Console.WriteLine("Fi.");
    }
}
