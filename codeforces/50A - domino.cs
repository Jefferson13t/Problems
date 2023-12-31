using System;

class Domino{

    static void Main(){
        double m = 0, n = 0, tot = 0;
        string[] entrada;

        entrada = Console.ReadLine().Split(' ');

        m = double.Parse(entrada[0]);
        n = double.Parse(entrada[1]);    
        
    if(m > n){

        tot += (double)Math.Floor((double)m / 2) * n;

        if(m % 2 == 1){
            tot += Math.Floor((double)n / 2);
        }
        
    } else {
        tot += (double)Math.Floor((double)n / 2) * m;
        if(n % 2 == 1){
            tot += Math.Floor((double)m / 2);
        }
    }

    Console.WriteLine(tot);
}
}