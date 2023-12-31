using System;

class Kefa{

    static void Main(){
        int n = int.Parse(Console.ReadLine());
        string[] entrada = Console.ReadLine().Split(' ');
        int max = 0;
        int count = 1;

        for(int i = 1; i < n; i++){
            if(long.Parse(entrada[i]) >= long.Parse(entrada[i - 1])){
                count++;
            } else {
                if(count > max){
                    max = count;
                }
                count = 1;
            }
        }
        if(count > max){
            max = count;
        }
        Console.WriteLine(max);
    }
}