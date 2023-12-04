using System.Text;

namespace SOLID.PRINCIPLES
{
     public class Accounts 
    {
        public EmployeeModel create(PersonModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.FirstName = person.firstName;
            output.LastName = person.lastName;
            output.EmailAddress = $"{person.firstName.Substring(0, 1)}{person.lastName}@gmail.com";
        }
    }
}
