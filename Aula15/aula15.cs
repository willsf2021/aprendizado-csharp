using System;

// Switch Case
class Aula15
{
    static void Main()
    {
        int tempo = 0;
        char escolha;

        Console.WriteLine("Belo Horizonte/MG a Vitória/ES");

        Console.WriteLine("Escolha o transporte: [a]Avião | [c]Carro | [o]Ônibus");
        escolha = char.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 'a':
            case 'A':
                tempo = 50;
                break;
            case 'c':
            case 'C':
                tempo = 480;
                break;
            case 'o':
            case 'O':
                tempo = 660;
                break;
            default:
                Console.WriteLine("Transporte Indisponível");
                break;
        }

        Console.WriteLine("Para o transporte escolhido o transporte é: {0} minutos", tempo);
    }
}