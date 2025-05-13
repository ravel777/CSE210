using System;

class Program
{
    static void Main(string[] args)
    {
        //Exercice 4
        List<int> listNumbers = new List<int>();
        int userNumber = -1;
        while (userNumber != 0){
            Console.Write("Enter a number (0 to quit): ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0){
            listNumbers.Add(userNumber);
            }
        }
        int sum = 0;
        foreach (int numb in listNumbers){
            sum += numb;
        }
        Console.WriteLine($"The sum is: {sum}");
        float average = sum / listNumbers.Count;
        Console.WriteLine($"The average is: {average}");

        int maxi = listNumbers[0];
        foreach (int nberMaxi in listNumbers){
            if (nberMaxi > maxi){
                maxi = nberMaxi;
            }
        }
        Console.WriteLine($"The largest number is: {maxi}");

        int mini = listNumbers[0];
        foreach (int nberMini in listNumbers){
            if (nberMini < mini){
                mini = nberMini;
            }
        }
        Console.WriteLine($"The smallest number is: {mini}");

        for (int i =0; i < listNumbers.Count; i++){
            int numberSorted = listNumbers[i];
            Console.WriteLine(numberSorted);
        }
    }
}