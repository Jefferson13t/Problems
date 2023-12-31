using System;

class SquareTheatre {

    static void Main(){

    string[] e = Console.ReadLine().Split(' ');

    long m = long.Parse(e[0]);
    long n = long.Parse(e[1]);
    long a = long.Parse(e[2]);

    double qM = (double)Math.Ceiling((double)m / a);
    double qN = (double)Math.Ceiling((double)n / a);

    
    Console.WriteLine((long)(qM * qN));

    }

}