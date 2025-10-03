namespace exercici10;

/* Declara dues variables: una per al nom i una altra per l’any de naixement. 
Combina-les per crear una contrasenya bàsica (per exemple, Pere i 1982 -> Pere1982). 
Imprimeix la contrasenya generada (i sobretot no la facis servir mai que és molt dolenta) */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercici nº9");
        var Nom = "Pere";
        var Any_naixe = 1982;
        Console.WriteLine($"Nom {Nom} i Any de naixement {Any_naixe} ");
        string contrasenya = string.Concat(Nom, Any_naixe);
        Console.WriteLine($"La contrasenya es {contrasenya} ");
    }
}
