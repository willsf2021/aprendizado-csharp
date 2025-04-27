using System;

class Ex3
{
    static void Main()
    {

        int idade = 29;
        float altura = 1.75f;
        char genero = 'M';
        bool casado = true;

        Console.WriteLine("Idade: {0}", idade);
        Console.WriteLine("Altura: {0}", altura);
        Console.WriteLine("Gênero: {0}", genero);
        Console.WriteLine("Casado?: {0}", (casado ? "Sim" : "Não"));

    }
}