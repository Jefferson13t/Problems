using System;

class Aula {

    static void Main() {
        int n1;
        n1 = Int32.Parse(Console.ReadLine());

        if(n1 % 2 == 0 && n1 > 2){
            Console.WriteLine("YES");
        } else {
            Console.WriteLine("NO");
        }
    }
}