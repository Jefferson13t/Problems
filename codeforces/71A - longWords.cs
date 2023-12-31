using System;

class LongWords {
    static void Main() {
        int n;
        string word;

        n = Int32.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++){
            word = Console.ReadLine();
            Console.WriteLine(codify(word));
        }

    }

    static string codify(string word){
        int length = word.Length; 
        if(length <= 10){
            return word;
        }

        return word[0] + (length - 2).ToString() + word[length - 1];

    }
}