using System;

class Program
{
    static void Main(string[] args)
    {
        //Exercice 3
        Random randGen = new Random();
        int magicNumber = randGen.Next(1, 70);

        int guessedNumber = -1;
        while (guessedNumber != magicNumber){

            Console.WriteLine("What's your guess? ");
            string guess = Console.ReadLine();
            guessedNumber = int.Parse(guess);

            if (guessedNumber > magicNumber){
                Console.WriteLine("Higher!");
            }
            else if (guessedNumber < magicNumber){
                Console.WriteLine("Lower!");
            }
            else if (guessedNumber == magicNumber){
                Console.WriteLine("You guessed it!");
            }
            else {
                Console.WriteLine("Something went wrong. Please try again!");
            }
        }
    }
}