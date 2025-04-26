using System;

// Lendo valores do teclado
class Aula08 {
    static void Main(){
        int v1, v2, soma;
        // string nome;

        // Console.Write("Digite seu nome: ");
        // nome = Console.ReadLine();

        // Console.WriteLine("Seu nome é {0}", nome);




        // Console.Write("Digite o primeiro valor: ");
        // v1 = Console.ReadLine(); // Note que sem a conversão dará erro!
        // Console.Write("Digite o segundo valor: ");
        // v2 = Console.ReadLine(); // Note que sem a conversão dará erro!
        // soma = v1 + v2;
        // Console.WriteLine("A soma de {0} mais {1} é igual a {2}", v1, v2, soma);


        Console.Write("Digite o primeiro valor: ");

        v1 = int.Parse(Console.ReadLine()); // Assim..
        Console.Write("Digite o segundo valor: ");
        v2 = Convert.ToInt32(Console.ReadLine()); // ou assim.


        soma = v1 + v2;
        Console.WriteLine("A soma de {0} mais {1} é igual a {2}", v1, v2, soma);


    }
}