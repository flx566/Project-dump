using System;

class Program
{
    static void Main()
    {
        string userInput = Console.ReadLine();
        string correct1 = "V=IR";
        string correct2 = "V = I * R";

        if (userInput == correct1 || userInput == correct2)
            Console.WriteLine("Верно");
        else
            Console.WriteLine("Неверно");
    }
}