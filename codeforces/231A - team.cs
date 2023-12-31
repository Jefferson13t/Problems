using System;

class Team {

    static void Main() {
        int n, p = 0;
        
        n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++){
            string[] e = Console.ReadLine().Split(' ');
            int t = Int32.Parse(e[0]) + Int32.Parse(e[1]) + Int32.Parse(e[2]);

            if(t > 1){
                p++;
            }
        }
        Console.WriteLine(p);
    }
}