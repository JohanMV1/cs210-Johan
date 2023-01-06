using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string useranswer = Console.ReadLine();
        int percentage = int.Parse(useranswer);

        string gradeletter = "";
        
        if (percentage >= 90)
        {
            gradeletter = "A";
        }
        else if (percentage >= 80)
        {
            gradeletter = "B";
        }
        else if (percentage >= 70)
        {
            gradeletter = "C";
        }
        else if (percentage >= 60)
        {
            gradeletter = "D";
        }
        else
        {
            gradeletter ="F";
        }

        Console.WriteLine($"Your grade is {gradeletter}");

        if (percentage >= 70)
        {
            Console.WriteLine("You passed! ");
        }
        else
        {
            Console.WriteLine("You failed, Good luck next time!");
        }

    }
}