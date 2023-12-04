using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BasicMathTest
{
    [TestClass]
    public class UnitTest1

    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public int BookYear { get; set; }


        [TestMethod]
        public void TestMethod1(string firstname, string lastname, string title, int year)
        {
            FirstName = firstname;
            LastName = lastname;
            Title = title;
            BookYear = year;

            Console.WriteLine("This is the best selling book of the year\n");
        }
    }
}
