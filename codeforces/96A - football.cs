using System;

class Football {

    static void Main(){
        string entrada = Console.ReadLine();
        int total = 1;
        char current = ' ';

        for(int i = 0; i < entrada.Length; i++){
            if(entrada[i] == current){
                total++;
                if(total >= 7){
                    break;
                }
            } else {
                current = entrada[i];
                total = 1;
            }
        }
        if(total >= 7){
            Console.WriteLine("YES");
        } else {
            Console.WriteLine("NO");
        }
    }
}