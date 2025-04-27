using System;

class Ex9
{
    static void Main()
    {
        int val1, val2;
        bool flag = false;

        Console.WriteLine("Informe o primeiro valor inteiro: ");
        val1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o segundo valor inteiro: ");
        val2 = int.Parse(Console.ReadLine());
        flag = (val1 & val2) > 0;

        Console.WriteLine("Ambos valores positivos? {0}", flag);

    }
}