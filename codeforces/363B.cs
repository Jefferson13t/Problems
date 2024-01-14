using System;

class Piano{
    static void Main(){
        long[] nk = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
        long n = nk[0] - 1;
        long k = nk[1] - 1; 
        long[] heights = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
        long index = 0;
        long minHeight = 0;
        long height = 0;

        for(long i = 0; i <= k; i++){
            height += heights[i];
        }
        minHeight = height;
        index = 1;

        long leftPtr = 0;
        long rightPtr = k;

        while(rightPtr < n){

            height -= heights[leftPtr];
            leftPtr++;
            rightPtr++;
            height += heights[rightPtr];

            if(height < minHeight){
                minHeight = height;
                index = leftPtr + 1;
            }
        }

        Console.WriteLine(index);
    }
}