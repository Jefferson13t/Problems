using System;

class FakeTree{

    static void Main(){
        long n = long.Parse(Console.ReadLine());

        for(long i = 0; i < n; i++){
            long e = long.Parse(Console.ReadLine());
            long total = 0;
            if(e % 2 == 1){
                total +=1;
                e = e - 1;
            }
            while(e >= 1){
                total += e;
                e /= 2;
            }
        Console.WriteLine(total);
        }
    }
}