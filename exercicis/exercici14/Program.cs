namespace exercici14;

// Declara una paraula i fes que el programa imprimeixi només la primera lletra, l'última lletra i la lletra del mig 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercici nº. 14");
        string paraula = "cotxe";
        char lletra_mig = paraula[2];
        char lletra_final = paraula[4];
        Console.WriteLine($"LLetra del mig i ultima lletra de {paraula} son {lletra_mig} i {lletra_final} ");

    }
}
