

using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Xml.Schema;

int studentExams = 3;

int mathScore = 70;
int englishScore = 30;
int physicsScore = 20;

int totalSum = mathScore + englishScore + physicsScore;

int GradeA = 5;
int GradeB = 4;
int GradeC = 3;
int GradeD = 2;
int GradeE = 1;
int GradeF = 0;


Console.WriteLine("JohnDoe,to view your grade, Please, enter your score: ");
int mark = int.Parse(Console.ReadLine());

//int gradePoint = totalSum % 3;


if (mark >= 70)
{
    Console.WriteLine("Your Grade is: A");
}
else if (mark >= 60)
{
    Console.WriteLine("Your Grade is: B ");
}
else if (mark >= 50)
{
    Console.WriteLine("Your Grade is: C ");
}
else if (mark >= 45)
{
    Console.WriteLine("Your Grade is: D ");
}
else if (mark > 40)
{
    Console.WriteLine("Your Grade is: E ");
}
else
{
    Console.WriteLine("Your Grade is: F ");
}


