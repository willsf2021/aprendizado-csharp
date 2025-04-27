using System;

// Operações de Bitwise
class Aula09
{

    static void Main()
    {


        // << Esquerda => Dobro do valor
        // >> Direita => Metade do valor
        int num = 10;

        // Dobra para 20;
        num = num << 1; // O 1 mostra quantos bits serão deslocados, se for 2, multiplica por 2, e assim por diante.

        // Mostra 20;
        Console.WriteLine(num);

        // Metade de 20, mostra 10;
        num = num >> 1; // O 1 mostra quantos bits serão deslocados, se for 2, divide por 2, e assim por diante.

        // Mostra 10;
        Console.WriteLine(num);
    }
}