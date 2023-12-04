

namespace Practice_on_Method
{
  public class Book
                            {
                            public string FirstName { get; set; }
                            public string LastName { get; set; }
                            public string Title { get; set; }
                            public int BookYear {get; set;}
  public Book(string firstname, string lastname, string title, int year) 
        
                            {
                            FirstName = firstname;
                            LastName = lastname;
                            Title = title;
                            BookYear = year;

                            Console.WriteLine("This is the best selling book of the year\n");
                            }
                            }

}

