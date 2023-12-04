

using System.Text.Encodings.Web;



student[][] Squad19 = new student[3][]; //declaration


//assignment

Squad19[0] = new student[3] {
    new student { Id = 1, Name = "bisi"},
    new student { Id = 2, Name = "buchi"},
    new student { Id = 3, Name = "basil"} };


Squad19[1] = new student[2] {
    new student { Id = 1, Name = "Brit"},
    new student { Id = 2, Name = "buchu"} 
                             };



Squad19[2] = new student[1] {
    new student { Id = 1, Name = "bisi"},
                             };


//accessing Data
var java = Squad19[0];
var Node = Squad19[1];
var dotNet = Squad19[2];





Console.WriteLine("\nJava devs");
Console.WriteLine("----------");
foreach (student student in java)
{
    Console.WriteLine($"Student Id: {student.Id}, Student Name {student.Name}");
}


Console.WriteLine("\nNode devs");
Console.WriteLine("----------");
foreach (student student in Node)
{
    Console.WriteLine($"Student Id: {student.Id}, Student Name {student.Name}");
}


Console.WriteLine("\ndotNet devs");
Console.WriteLine("----------");
foreach (student student in dotNet)
{
    Console.WriteLine($"Student Id: {student.Id}, Student Name {student.Name}");
}

Console.ReadLine();




















class student
{
    public int Id;
    public string Name;
}




  