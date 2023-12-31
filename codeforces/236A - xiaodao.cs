using System;
using System.Collections.Generic;

class xiaodao{

    static void Main(){
        string entrada = Console.ReadLine();
        HashSet<char> set = new HashSet<char>();

        for(int i = 0; i < entrada.Length; i++){
            set.Add(entrada[i]);
        }

        if(set.Count % 2 == 0){
            Console.WriteLine("CHAT WITH HER!");
        } else {
            Console.WriteLine("IGNORE HIM!");
        }
    }
}