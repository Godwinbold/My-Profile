Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
//Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} ");
Console.WriteLine($"Dice roll: = total ");

if (total > 10)
{
    Console.WriteLine("You win");
}

if (total < 10)
{
    Console.WriteLine("You lose!");
}
    Console.WriteLine("Try again (-_-)");
Console.Write("Thank you");
{
    
}
Console.ReadLine();
