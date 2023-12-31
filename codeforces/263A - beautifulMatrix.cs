using System;

class Matrix {

    static void Main() {

        string[][] matrix = new string[5][];
        int i = 0; 
        int j = 0;

        for(int k = 0; k < 5; k++){
            matrix[k] = Console.ReadLine().Split(' ');
            int aux = Array.IndexOf(matrix[k], "1");

            if(aux != -1){
                i = k + 1;
                j = aux + 1;
            }
        }
        Console.Write(Math.Abs(i - 3) + Math.Abs(j - 3));
    }
}