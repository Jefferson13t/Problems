using System;

class Taxi{

    static void Main(){
        long n = long.Parse(Console.ReadLine());
        string[] entrada = Console.ReadLine().Split(' ');
        long g1 = 0;
        long g2 = 0;
        long g3 = 0;
        long g4 = 0;
        long min = 0;
        long total = 0;


        for(long i = 0; i < n; i++){
            switch(entrada[i]){
                case "1":
                    g1++;
                    break;
                case "2":
                    g2++;
                    break;
                case "3":
                    g3++;
                    break;
                case "4":
                    g4++;
                    break;
                default:
                    break;                    
            }
        }

        total += g4;

        min = Math.Min(g1, g3);
        total += min;
        g1 -= min;
        g3 -= min;
        total += g3;
        total += g2 / 2;
        g2 = g2 % 2;
        total += g2;
        if(g2 > 0){
            g1 = g1 - g2 * 2 > 0 ? g1 - 2 : 0;
        }
        total += g1 / 4;
        g1 -= (g1 / 4) * 4;
        total += g1 > 0 ? 1 : 0;

        Console.WriteLine(total);
    }
}