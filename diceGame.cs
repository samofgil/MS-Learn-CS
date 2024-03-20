using System.Formats.Asn1;
using System.Text.RegularExpressions;
Console.WriteLine("\nWelcome to the Dice Game! \nType \'r\' to roll, \'f\' for a fast game, or \'q\' to quit.");
Random rollOdds = new();
int roll=0;
int roll2=0;
int roll3=0;
int total=0;
string input = "";

input = Console.ReadLine();
if (input=="f")
{
    Console.WriteLine("\nRoll a grand total of 14 points to win!");
    roll = rollOdds.Next(1, 7);
    total += roll;
    roll2 = rollOdds.Next(1, 7);
    total += roll2;
    roll3 = rollOdds.Next(1, 7);
    total += roll3;
    Console.WriteLine($"\nROLL: {roll} + {roll2} + {roll3} = {total}");
    if ((roll == roll2) || (roll2 == roll3) || (roll == roll3))
    {
        if ((roll == roll2) && (roll2 == roll3))
        {
            Console.WriteLine("You rolled triples!  +6 bonus points to total!");
            total += 6;
        }
        else
        {
            Console.WriteLine("You rolled doubles!  +2 bonus points to total!");
            total += 2;
        }
        Console.WriteLine($"Your total (including bonus points): {total}");
    }

    if (total<14)
    {
        Console.WriteLine("Sorry, you didn\'t win this time.");
    }
    else
    {
        Console.WriteLine("Congratulations, you win!");
    }
    return;
}

if (input=="r")
{
    roll = rollOdds.Next(1, 7);
    total += roll;
    Console.WriteLine($"Roll 1: \t\t{roll}");
}
else if (input=="q")
{
    Console.WriteLine($"Total Score: \t\t{total}\n");
    Console.WriteLine("Thanks for playing!");
    return;
}
else
{
    Console.WriteLine($"Roll 1 Missed.");
}
Console.WriteLine("\nType \'r\' to try to roll again, or \'q\' to quit.");

input = Console.ReadLine();
if (input=="r")
{
    roll2 = rollOdds.Next(1, 7);
    total += roll2;
    Console.WriteLine($"Roll 2: \t\t{roll2}");
}
else if (input=="q")
{
    Console.WriteLine($"Total Score: \t\t{total}\n");
    Console.WriteLine("Thanks for playing!");
    return;
}
else
{
    Console.WriteLine($"Roll 2 Missed.");
}
Console.WriteLine("\nType \'r\' to try rolling one last time, or \'q\' to quit.");

input = Console.ReadLine();
if (input=="r")
{
    roll3 = rollOdds.Next(1, 7);
    total += roll3;
    Console.WriteLine($"Roll 3: \t\t{roll3}\n");
}
else if (input=="q")
{
    if (roll==roll2)
    {
        Console.WriteLine($"(2 Pair): \t\t2");
        total += 2;
    }
    Console.WriteLine($"Total Score: \t\t{total}\n");
    Console.WriteLine("Thanks for playing!");
    return;
}
else
{
    Console.WriteLine($"Roll 3 Missed.");
}

if (roll==roll2 && roll2==roll3)
{
    Console.WriteLine($"Triples!: \t\t+6");
    total += 6;
}
else if ((roll==roll2 || roll2==roll3 || roll==roll3) && roll3!=0)
{
    Console.WriteLine($"Doubles!: \t\t+2");
    total += 2;
}
Console.WriteLine($"Total Score: \t\t{total}\n");

if (total >= 16)
    {
        Console.WriteLine("You win a new car!");
    }
    else if (total >= 10)
    {
        Console.WriteLine("You win a new laptop!");
    }
    else if (total == 7)
    {
        Console.WriteLine("You win a trip for two!");
    }
    else
    {
        Console.WriteLine("You win a kitten!");
    }

Console.WriteLine("Thanks for playing!");