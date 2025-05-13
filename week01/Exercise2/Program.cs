using System;

class Program
{
    static void Main(string[] args)
    {
        //Exercice 2
        Console.Write("Enter your percentage: ");
        string grades = Console.ReadLine();
        int grade = int.Parse(grades);
        if (grade >= 90){
            Console.WriteLine("You've got an 'A'. Well done!");
        }
        else if (grade >= 80){
            Console.WriteLine("You've got an 'B'. Nice job!");
        }
        else if (grade >= 70){
            Console.WriteLine("You've got an 'C'. Not bad!");
        }
        else if (grade >= 60){
            Console.WriteLine("You've got an 'D'. You must have at least a 'C' to pass the class");
        }
        else if (grade < 60){
            Console.WriteLine("You've got an 'F'. You need to make more efforts to pass the class.");
        }
        else {
            Console.WriteLine("Something went wrong. Please try again!");
        }
    }
}