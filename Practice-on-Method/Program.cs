using Practice_on_Method;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Godwin
{
    class program
    {

  static void Main(string[] args)
                            {
    Book book1 = new Book("Godwin", "Ozioko", "Foot-Soldier", 2023);

                            Console.WriteLine("The very best, written by "
                            + book1.FirstName + " "
                            + book1.LastName + " in the year "
                            + book1.BookYear);


      Console.WriteLine("I shall appreciate your ratings...\n Thank you sincerely!\n\n");


      Console.WriteLine("Please, Enter your name...\n");
                            string name = Console.ReadLine();
                            Console.WriteLine("Please, Enter your Lastname...");
                            string lastname = Console.ReadLine();
                            Console.WriteLine("Hello "+ name +" " + lastname + " thank you for your feedback");
                            Console.ReadLine();

       
                            }



   }
}