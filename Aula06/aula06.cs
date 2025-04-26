using System;

class Aula06
{

    // Formatações de Saída
    static void Main()
    {
        // Console.Write(); // Não tem quebra da linha
        // Console.WriteLine(); // Tem quebra de linha

        int n1, n2, n3;

        n1 = 10; n2 = 20; n3 = 30;

        Console.WriteLine(n1 + ", " + n2 + " ," + n3); // Forma tradicional

        Console.WriteLine("n1 = {0}, n2 = {1}, n3 = {2}",n1, n2, n3); // Uso de índices

        
        Console.WriteLine("n1 = {0}\n n2 = {1}\n n3 = {2}\n",n1, n2, n3); 


        Console.WriteLine("n1 = {0}\t n2 = {1}\t n3 = {2}\t",n1, n2, n3); 

        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";

        valorVenda = valorCompra+(valorCompra * lucro);

        Console.WriteLine("Produto.........:{0,15}", produto);
        Console.WriteLine("Valor Compra.........:{0,15:c}", valorCompra);
        Console.WriteLine("Valor Lucro.........:{0,15:p}", lucro);
        Console.WriteLine("Valor de Venda.........:{0,15:c}", valorVenda);
    }
}