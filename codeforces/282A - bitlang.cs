using System;

class Bitlang {

    static void Main() {

        int n;
        int x = 0;


        n = Int32.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++) {
            string entrada = Console.ReadLine();

            if(entrada.IndexOf("+") >= 0){
                x++;
            }
            if(entrada.IndexOf("-") >= 0){
                x--;
            }
        }

        Console.WriteLine(x);
    }
}