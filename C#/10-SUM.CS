using System;

class Program
{
    static double CalculateAverage(int[] marks)
    {
        int sum = 0;

        for (int i = 0; i < marks.Length; i++)
        {
            sum += marks[i];
        }

        return (double)sum / marks.Length;
    }

    static void Main()
    {
        int[] marks = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter mark for subject " + (i + 1) + ": ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        double average = CalculateAverage(marks);

        Console.WriteLine("Average = " + average);

        if (average >= 40)
            Console.WriteLine("Passed");
        else
            Console.WriteLine("Failed");
    }
}
