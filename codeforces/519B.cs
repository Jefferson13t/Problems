using System;

class Piano{
    static void Main(){
        long n = long.Parse(Console.ReadLine());
        long[] first = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
        long[] second = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
        long[] third = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);

        long firstSum = 0;
        long secondSum = 0;
        long thirdSum = 0;

        long firstRest = third.Length;
        long secondRest = third.Length;

        for(int i = 0; i < third.Length; i++){
            firstSum += first[i];
            secondSum += second[i];
            thirdSum += third[i];            
        }   

        firstSum += first[firstRest] + first[firstRest + 1];
        secondSum += second[secondRest];

        Console.WriteLine(firstSum - secondSum); 
        Console.WriteLine(secondSum - thirdSum); 
    }
}