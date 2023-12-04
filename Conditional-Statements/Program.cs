using System.ComponentModel.Design;

Random gameRoll = new Random();

var roll1 = gameRoll.Next(1,7);
var roll2 = gameRoll.Next(1, 7);
var roll3 = gameRoll.Next(1, 7);


//Console.WriteLine("please enter time: ");
//Time = int.Parse(Console.ReadLine());
var total = roll1 + roll2 + roll3;

Console.WriteLine( total);


Console.WriteLine("please Roll Dice: ");
int Rill = int.Parse(Console.ReadLine());

 if ((roll1 == roll2) || (roll2 == roll3));
{

    Console.WriteLine("You have won a car: ");
    total += 5;
}

 if (total > 40)
{
    Console.WriteLine("You won a house");
    total += 7;
}

 else if (total <5 )
{
    Console.WriteLine("Please, try again!");
}
 else
{
   Console.WriteLine("Thank you for your patronage");
}


