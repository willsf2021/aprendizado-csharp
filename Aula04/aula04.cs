using System;

// Escopo de variáveis
class Aula04
{

    static int num = 10;

    static void Main()
    {
        // num só está disponível no escopo do método Main
        int num2 = 0;
        Console.WriteLine(num);
    }

    void teste()
    {
        // Erro ao Compilar (fora do contexto atual)
        // Console.WriteLine(num);

        int num3 = 0;
        Console.WriteLine(num);
    }
}