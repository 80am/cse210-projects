using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);

        string lgrade = "";

        if (percent >= 90)
        {
            lgrade = "A";

        }
        else if (percent >= 80)
        {
            lgrade = "B";
        }
        else if (percent >= 70)
        {
            lgrade = "C";
        }
        else if (percent >= 60)
        {
            lgrade = "D";
        }
        else 
        {
            lgrade = "F";
        }
        Console.WriteLine($"Your grade is: {lgrade}");

        if (percent >= 70)
        {
            Console.WriteLine("You Passed the Grade!");
        }
        else
        {
            Console.WriteLine("You can always try again next time");
        }

    }
}