using System;

class Ex5
{
    static void Main()
    {

        int val1, val2;


        do
        {
            Console.WriteLine("Informe o primero número: ");
            val1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            val2 = int.Parse(Console.ReadLine());
            if (val2 == 0)
            {
                Console.WriteLine("Para a operação de Divisão o denomiador não pode ser zero! Por favor refaça as atribuições");

            }
        } while (val2 == 0);

        // Soma
        Console.WriteLine("Soma: {0}", val1 + val2);
        // Substração
        Console.WriteLine("Substração: {0}", val1 - val2);
        // Multiplicação
        Console.WriteLine("Multiplicação: {0}", val1 * val2);
        // Divisão
        Console.WriteLine("Divisão: {0}", val1 / val2);
    }
}