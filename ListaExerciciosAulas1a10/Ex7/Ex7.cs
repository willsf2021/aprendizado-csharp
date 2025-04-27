using System;

class Ex7
{
    static void Main()
    {
        const float pi = 3.1415f;
        float raio = 0.0f;
        float area;

        // Fórmula para calcular a área de um círculo: a = π.r²;

        Console.WriteLine("Informe o raio da circunferência: ");
        raio = float.Parse(Console.ReadLine());

        if (raio > 0)
        {
            area = pi * (raio * raio);
            Console.WriteLine("O valor da área da circunferência com raio {0}cm é: {1}cm²", raio, area);

        }
        else
        {
            Console.WriteLine("O Raio deve ser maior que zero!");
        }



    }
}