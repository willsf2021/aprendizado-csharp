using System;

class Ex8
{
    static void Main()
    {

        int val1, val2;

        Console.WriteLine("Informe o primeiro valor: ");
        val1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o segundo valor: ");
        val2 = int.Parse(Console.ReadLine());

        if (val1 == val2)
        {
            Console.WriteLine("{0} e {1} são iguais", val1, val2);
            return;
        }
        Console.WriteLine("{0} {1} não são iguais", val1, val2);
    }
}