using System;

// Go To
// Dificulta leitura, dificulta manutenção, fluxo imprevisível.
// Estruturas de Repetição são PREFERÍVEIS
class Aula16
{
    static void Main()
    {
        int tempo = 0;
        char escolha;

    inicio: // Label

        Console.Clear();

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


        if (tempo < 0)
        {
            Console.WriteLine("Transporte Indisponível");
        }
        else
        {
            Console.WriteLine("Para o transporte escolhido o transporte é: {0} minutos", tempo);
        }

        Console.Write("\nCalcular outro transporte?[s/n]: ");
        escolha = char.Parse(Console.ReadLine());

        if (escolha == 's' || escolha == 'S')
        {
            goto inicio;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("fim do programa");
            return;
        }

    }
}