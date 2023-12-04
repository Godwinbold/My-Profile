int studentAssignments = 3;

    string gradePoin5 = A
    string gradePoint4 = B
    string gradePoint3 = C
    string gradePoint2 = D
    string gradePoint1 = E
    string gradePoint0 = F

int johnDoe1 = 70;
int johnDoe2 = 20;
int johnDoe3 = 20;

int mathias1 = 80;
int mathias2 = 83;
int mathias3 = 82;

int sarah1 = 84;
int sarah2 = 96;
int sarah3 = 73;

int king1 = 90;
int king2 = 92;
int king3 = 98;

// int johnDoeSum = 0;
// int mathiasSum = 0;
// int sarahSum = 0;
// int kingSum = 0;

int johnDoeSum = johnDoe1 + johnDoe2 + johnDoe3;
int mathiasSum = mathias1 + mathias2 + mathias3;
int sarahSum = sarah1 + sarah2 + sarah3;
int kingSum = king1 + king2 + king3;


decimal johnDoeScore = (decimal) johnDoeSum / studentAssignments;
decimal mathiasScore = (decimal) mathiasSum / studentAssignments;
decimal sarahScore = (decimal) sarahSum / studentAssignments;
decimal kingsScore = (decimal) kingSum / studentAssignments;


//Console.WriteLine("johnDoe: " + johnDoeSum / studentAssignments);
//Console.WriteLine("mathias: " + mathiasSum / studentAssignments);
//Console.WriteLine("sarah: " + sarahSum / studentAssignments);
//Console.WriteLine("king: " + kingSum / studentAssignments);

Console.WriteLine("please enter your name: ");
gradePoint = int.Parse(Console.ReadLine());


if (totalGradeSum >= 70)
{
    Console.WriteLine($"You got {gradePoin5}");
}

