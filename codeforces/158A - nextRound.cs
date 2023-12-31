using System;

class NextRound {

    static void Main(){

        int q = 0, lim = 0;
        string[] e = Console.ReadLine().Split(' ');
        string[] p = Console.ReadLine().Split(' ');


        if(p.Length < Int32.Parse(e[1])){
            lim = 1;
        } else {
            lim = Int32.Parse(p[Int32.Parse(e[1]) - 1]);
        }

        for(int i = 0; i < p.Length; i++){
            if(Int32.Parse(p[i]) >= lim && Int32.Parse(p[i]) > 0){
                q++;
            }
        }

        Console.WriteLine(q);
    }
}