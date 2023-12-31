using System;

class Physicist{

    static void Main(){
        int n = Int32.Parse(Console.ReadLine());
        long sumI = 0;
        long sumJ = 0;
        long sumK = 0;

        for(int i = 0; i < n; i++){
            string[] entrada = Console.ReadLine().Split();
            sumI += long.Parse(entrada[0]);
            sumJ += long.Parse(entrada[1]);
            sumK += long.Parse(entrada[2]);
        }
        if(sumI == 0 && sumJ == 0 && sumK == 0){
            Console.WriteLine("YES");
        } else {
            Console.WriteLine("NO");
        }
    }
}