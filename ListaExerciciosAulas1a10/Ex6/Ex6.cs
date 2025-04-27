using System;

class Ex5
{
    static void Main()
    {
        int resultado = 5 + 2 * 3; // Pela prioridade das operações o resultado será 11

        Console.WriteLine("Resultado sem parênteses: {0}", resultado);

        resultado = (5 + 2) * 3; // Adicionando os parênteses e pela prioridade das operações o resultado será 21
        Console.WriteLine("Resultado com parênteses: {0}", resultado);
    }
}