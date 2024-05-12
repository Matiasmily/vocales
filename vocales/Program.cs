// See https://aka.ms/new-console-template for more information
string texto;
int contador;
contador = 0;
Console.WriteLine();
Console.WriteLine("Vocales en el texto");
Console.WriteLine();
Console.Write("Ingrese el texto: ");
texto = Console.ReadLine().ToLower();
Console.WriteLine();

foreach (char vocales in texto)
{
    if (vocales == 'a' || vocales == 'e' || vocales == 'i' || vocales == 'o' || vocales == 'u' || vocales == 'á' || vocales == 'é' || vocales == 'í' || vocales == 'ó' || vocales == 'ú')
    {
        contador++;
    }
}
Console.WriteLine("El texto tiene " + contador + " vocales");

