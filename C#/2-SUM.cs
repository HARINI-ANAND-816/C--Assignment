using System;

class Program
{
    static void Main()
    {
        double price = 1000.0;
        double discount = 10.0;

        double discountAmount = price * discount / 100;
        double finalPrice = price - discountAmount;

        Console.WriteLine("Final Price = " + finalPrice);
    }
}
