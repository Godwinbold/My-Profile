// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");





string[] dotNrt = new string[5];

for (int i = 0; i < dotNrt.Length; i++)
{
    Console.WriteLine("What is the name of the number {0} student :",i+1);
    dotNrt[i] = Console.ReadLine();
   
}
foreach (string name in dotNrt)
{
    Console.Write(name+"," );

}








int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int sum = 0;
//int sum2 = 0;

for (int i = 0; i < 13; i++)
{
    sum = i * 3;

    Console.WriteLine("{0} * 3 = {1} {2}", i, sum);

}

Console.ReadLine();


