using System;
using System.Collections.Generic;

class Drink{
    static void Main(){
        long barNumber = long.Parse(Console.ReadLine());
        long[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
        long days = long.Parse(Console.ReadLine());

        Array.Sort(prices);

        for(long i = 0; i < days; i++){
            long money = long.Parse(Console.ReadLine());
            Console.WriteLine(ContarMenoresQueLimite(prices, money));
        }
    }

    static long ContarMenoresQueLimite(long[] vetorOrdenado, long limite)
    {
        long inicio = 0;
        long fim = vetorOrdenado.Length - 1;
        long indiceDoLimite = -1;

        // Encontrar o índice do limite usando busca binária
        while (inicio <= fim)
        {
            long meio = (inicio + fim) / 2;

            if (vetorOrdenado[meio] <= limite)
            {
                indiceDoLimite = meio;
                inicio = meio + 1;
            }
            else
            {
                fim = meio - 1;
            }
        }

        // Retornar a quantidade de itens menores que o limite
        return indiceDoLimite + 1;
    }
}