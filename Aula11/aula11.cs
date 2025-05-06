using System;

// Type Cast
class Aula11
{
    static void Main()
    {
        int n1 = 10;
        float n2 = n1; // Conversão Implícita;

        float n3 = 10.5f;
        int n4 = (int) n3; // Conversão Explícita `type cast`

        Console.Write(n4);
    }
}