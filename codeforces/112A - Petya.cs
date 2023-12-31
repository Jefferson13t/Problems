using System;

class Petya{

    static void Main(){
        string a, b;
        int res = 0;
        a = Console.ReadLine().ToLower();
        b = Console.ReadLine().ToLower();

        for(int i = 0; i < a.Length; i++){

            if((int)(a[i]) < (int)(b[i])){
                res = -1;
                break;
            }
            if((int)(a[i]) > (int)(b[i])){
                res = 1;
                break;
            }

        }
        Console.WriteLine(res);
    }
}