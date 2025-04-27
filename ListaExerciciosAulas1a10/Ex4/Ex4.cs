using System;

class Ex4
{
    static void Main()
    {


        if (10 > 1)
        {
            int escopo = 10;
        }

        Console.Write(escopo);
        // Ao tentar acessar a varia´vel `escopo` fora do bloco do if receberei um erro ao tentar compilar dizendo que:
        // "o nome 'escopo' não existe no contexto atual" ou seja, no contexto que foi chamado, fora do escopo do if. 
    }
}