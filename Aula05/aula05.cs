using System;

// Operadores e Operações
class Aula05
{
    static void Main()
    {
        // Atribuição, Soma e Multiplicação
        int res = (10 + 5) * 2;

        // Operadores relacionais/lógicos
        // > < >= <= !=
        bool res1 = 10 > 5;

        // Operadores de incremento e decremento
        int num = 10;

        // num = num + 1;

        // num += 1; // Subtração, divisão e multiplicação também se aplicam
        num++;

        // & = AND / E
        // |  OR / OU
        bool res2 = (5 > 3); // True

        res2 = (10 > 5) | (10 < 5); // Vai dar True

        res2 = (3 > 5) | (10 < 5); // Vai dar False

        res2 = (5 > 7) & (10 < 5); // Vai dar False

        res2 = (5 > 7) & (10 > 5); // Vai dar False

        res2 = (5 < 7) & (10 > 5); // Vai dar True
        
        Console.WriteLine(res2);

    }
}