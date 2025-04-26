using System;

// Variáveis

// C# é Fortemente tipada!
class Aula03
{
    static void Main()
    {
        // Byte é um variável de 8 bits que vai de 0 a 255
        byte n1 = 10; // Não tem sinal

        int num = 0; // Tem sinal

        // '' para char e "" para string
        char letra = 'c';

        // Para o tipo float devemos colocar o f no final
        float valor = 5.3f;

        // Conjunto de caracteres
        string nome = "Wilson";


        /* Operador var */

        // No momento da compilação o tipo da variável é definido com base na sua atribuição!
        var aux = 10; // Sem tipo especificado antes da compilação

        Console.WriteLine("Valor da variável: " + aux + "...");

        // Declarando múltiplas variáveis do mesmo tipo
        int num1, num2, res;

        num1 = 10;
        num2 = 2;
        res = num1 * num2;

        Console.WriteLine("A multiplicação de " + num1 + " vezes " + num2 + " é igual a : " + res);
        // ou
        Console.WriteLine("A multiplicação de " + num1 + " vezes " + num2 + " é igual a : " + num1 * num2);
    }
}