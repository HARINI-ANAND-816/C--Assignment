using System;

class Program
{
    static void Main()
    {
        int playerA = 20;
        int playerB = 15;

        Console.WriteLine("Player A scored more than B: " + (playerA > playerB));
        Console.WriteLine("Scores are equal: " + (playerA == playerB));
        Console.WriteLine("Player A is not less than B: " + (playerA >= playerB));
        Console.WriteLine("Player B is not greater than A: " + (playerB <= playerA));
    }
}
