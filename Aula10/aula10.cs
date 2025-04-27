using System;

// Enumeradores (Enum)
class Aula10
{
    // É como criar um tipo - Entre chanves estão os valores possível para esse novo tipo
    enum DiasSemana { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };
    static void Main()
    {

        DiasSemana ds = DiasSemana.Domingo;

        DiasSemana ds2 = (DiasSemana)2; // CASTING

        int dsInt = (int)DiasSemana.Sexta;

        Console.WriteLine(ds);

        Console.WriteLine(ds2);

        Console.WriteLine(dsInt);

    }
}