using System;

class Program
{
    static void Main(string[] args)
    {
        displayMessage();

        string userName = promptUserName();
        int userNumber = promptUserNumber();

        int squaredNumber = squareNumber(userNumber);

        displayResult(userName, squaredNumber);
    }

    static void displayMessage()
    {
        Console.WriteLine("Welcome to the program! ");
    }

    static string promptUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int promptUserNumber()
    {
        Console.Write("Enter Favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int squareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void displayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square} ");
    }
}