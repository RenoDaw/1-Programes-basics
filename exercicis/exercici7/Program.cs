namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercici nº7.");
        const float Nota1 = 3;
        const float Nota2 = 5;
        const float Nota3 = 8;
        float mitjana = (Nota1+Nota2+Nota3)/3;
        Console.WriteLine($"Notes nº1={Nota1}, nº2={Nota2}, nº3={Nota3}.");
        Console.WriteLine($"Nota mitjana es {mitjana}.");

    }
}
