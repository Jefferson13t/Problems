using System;
using System.Collections.Generic;

class SubStrings {
    private List<string> subStrings;

    public SubStrings(){
        this.subStrings = new List<string>();
    }

    public bool insert(string value){
        bool contains = this.subStrings.Contains(value);
        if(!contains){
            this.subStrings.Add(value);
        }
        return contains;
    }
    public long legth(){
        return this.subStrings.Count;
    }

    public void operate(string word){
        bool exists = this.insert(word);
        Console.WriteLine(word);
        if(word.Length <= 1){
            return;
        }
        if(!exists){
            operate(word.Remove(0, 1));
            operate(word.Remove(1, 1));
        }
    }
    public void clear(){
        this.subStrings.Clear();
    }
}

class EraseForS{
    static void Main(){
        int n = Int32.Parse(Console.ReadLine());
        SubStrings sub = new SubStrings();


        for(int i = 0; i < n; i++){
            int length = Int32.Parse(Console.ReadLine());
            string word = Console.ReadLine();
            sub.operate(word);
            //Console.WriteLine(sub.legth());
            sub.clear();
        }
    }
}