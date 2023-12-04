// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using static System.Formats.Asn1.AsnWriter;

class IntroToLINQ
{
    static void Main()
    {
        var number = new int[] { 1, 2, 3, 4, 5 };
        var filtered = from n in number
                       where n == 4 || n == 5
                       select n;

        foreach (var n in filtered)
        {
            Console.WriteLine(n);
        }







        // The Three Parts of a LINQ Query:
        // 1. Data source.
        int[] scores = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

        //2.Query creation.
        //numQuery is an IEnumerable < int >
       var numQuery =
           from num in scores
           where (num % 2) == 0
           select num;

        //3.Query execution.
        foreach (int num in numQuery)
        {
            Console.Write("{0,1} ", num);
        }

        IEnumerable<int> highScoresQuery =
                            from score in scores
                            where score < 10
                            orderby score ascending
                            select score;

        foreach (int score in scores )
        {
            Console.WriteLine($"The score is: " + score);
        }
        Console.ReadLine();
    }
}
