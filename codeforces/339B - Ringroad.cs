using System;

class Ringroad{

    static void Main(){
        string[] nm = Console.ReadLine().Split();
        long n = long.Parse(nm[0]);
        long m = long.Parse(nm[1]);
        string[] tasks = Console.ReadLine().Split();
        long prior = 0;
        long time = 0;

        for(int i = 0; i < m; i++){
            long current = long.Parse(tasks[i]);
            if(current > prior){
                time += current - prior;
            }
            if(current < prior){
                time += n - prior + current;
            }
            prior = long.Parse(tasks[i]);
        }
        Console.WriteLine(time - 1);
    }
}