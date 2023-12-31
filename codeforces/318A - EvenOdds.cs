using System;

class EvenOdds {
    static void Main() {
        string[] entrada = Console.ReadLine().Split();
        long n = long.Parse(entrada[0]);
        long k = long.Parse(entrada[1]);

        if(k <= n / 2){
            Console.WriteLine(k * 2 - 1);
        } else{
            if(n % 2 == 0){
                Console.WriteLine(k * 2 - n);
            } else if(k * 2 - 1 == n){
                Console.WriteLine(n);
            } else {
                Console.WriteLine(k * 2 - n - 1);
            }
        }
    } 
}