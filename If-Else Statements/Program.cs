//If-Else statement

//


class program
{
    static void Main(string[] args)
    {


        Console.WriteLine(Getday(2));
        Console.ReadLine();
    }
    static string Getday(int dayNum)
    {
        string dayName;

        switch (dayNum)
        {
            case 0:
                dayName = "Sunday";
                break;

            case 1:
                dayName = "Monday";
                break;

            case 2:
                dayName = "Tuesday";
                break;

            case 3:
                dayName = "Wednesday";
                break;

            case 4:
                dayName = "Thursday";
                break;

            case 5:
                dayName = "Friday";
                break;

            case 6:
                dayName = "Saturday";
                break;

            default:
                dayName = "Number not applicable";
                break;
        }


        return dayName;
       // Console.WriteLine(dayName);

    }


}





























//Console.WriteLine("Please, enter your age: ");

//int age = int.Parse(Console.ReadLine());

//Console.WriteLine("What is the movie rating?");
//char rating = char.Parse(Console.ReadLine());

//Console.WriteLine("Do you have a ticket?: ");
//bool ticket = bool.Parse(Console.ReadLine());

//   if ((age <= 12 || age >= 65) && rating == 'P')
//{
//    Console.WriteLine("Dear Customer, you got a discount");
//}
//   else
//{
//    Console.WriteLine("Please, Not your category");
//}if (ticket == true)
//{
//    Console.WriteLine("You are qualified");
//}







