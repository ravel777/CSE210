using System;

class Program
{
    static void Main(string[] args)
    {
        //Exercice 5
        //Display
        DisplayWelcome();

        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int numberSquared = NumberSquared(userNumber);

        DisplayResult(userName, numberSquared);
    }

    //Welcoming function
    static void DisplayWelcome() {
        Console.WriteLine("Dear guest, Welcome!");
    }

    //UserName function
    static string PromptUserName() {
        Console.Write("Please! Enter your full name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber() {
        Console.Write("Please! Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int NumberSquared(int a) {
        int square = a*a;
        return square;
    }

    static void DisplayResult(string name, int square) {
        Console.WriteLine($"Dear {name}, the square of your number is {square}");
    }
}