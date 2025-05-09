using System;

// Arrays Unidimensionais - Vetores
class Aula17
{
    static void Main()
    {
        int n1, n2, n3, n4, n5;

        // Tipo, nome | new, ou atribuição direta

        // Array do tipo Integer

        // Uma das formas de se declarar
        int[] n = new int[5]; // vai do 0 ao 4

        n[0] = 0;
        n[1] = 0;
        n[2] = 0;
        n[3] = 0;
        n[4] = 0;

        Console.WriteLine("N: {0}", n[0]);

        // Uma das formas de se declarar, já atribuindo valores;
        int[] num = new int[3] { 55, 77, 99 };
        Console.WriteLine("Num: {0}", num[0]);


        // Uma das formas de se declarar, tamanho do array depende da quantidade de arrays
        int[] num2 = {
            55, 77, 99
        };
        Console.WriteLine("Num2: {0}", num2[0]);

    }
}