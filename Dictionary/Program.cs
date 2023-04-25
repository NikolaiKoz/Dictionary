using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> personas = new Dictionary<string, int>();
        personas.Add("Jose", 25);
        personas.Add("María", 30);
        personas.Add("Belen", 20);
        personas.Add("Giuliano", 35);

        Console.WriteLine("Ingrese un nombre para buscar su edad:");
        string nombre = Console.ReadLine();

        int edad;
        if (personas.TryGetValue(nombre, out edad))
        {
            Console.WriteLine("La edad de {0} es {1} años.", nombre, edad);
        }
        else
        {
            Console.WriteLine("No se encontró la edad de {0}.", nombre);
        }
    }
}

