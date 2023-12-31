using System;

class Elephant{

    static void Main(){

        int distancia = Int32.Parse(Console.ReadLine());

        if(distancia > 5){
            int step = distancia % 5 == 0 ? 0 : 1;
            Console.WriteLine((distancia / 5) + step);
        } else {
            Console.WriteLine(1);
        }
    }
}