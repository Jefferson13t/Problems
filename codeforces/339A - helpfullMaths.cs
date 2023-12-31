using System;
using System.Linq;
using System.Collections.Generic;

class Xenia {

    static void Main() {
        string[] entrada = Console.ReadLine().Split('+');
        
        Console.WriteLine(string.Join("+", Quicksort(entrada)));
    }

    static string[] Quicksort(string[] arr){

        if(arr.Length<=1){
            return arr;
        }

        string pivot = arr[arr.Length / 2];
        List<string> left = new List<string>();
        List<string> right = new List<string>();

        for(int i = 0; i < arr.Length; i++){

            if(i == arr.Length / 2) {
                continue;
            }

            if(Int32.Parse(arr[i]) < Int32.Parse(pivot)){
                left.Add(arr[i]);

            } else {
                right.Add(arr[i]);
            }
        }

        return Quicksort(left.ToArray())
            .Concat(new string[] { pivot })
            .Concat(Quicksort(right.ToArray()))
            .ToArray();
    }

}