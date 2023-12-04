using PayRollAssignment;
using System.Security.Cryptography.X509Certificates;

namespace Payroll.TEST
{
    public class PayrollMethodTest
    {

        [Fact]
        public void CalculateGrossPayIsCorrect()
        {

            //arrange

            decimal grosspay = 200m;
            decimal deductions = 50m;
            
            decimal expected = 150;
            Employee emp = new Employee();

            //act

            decimal actual = grosspay - deductions;

            //assert

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void ShouldCalculateCorrectGrossPay()
        {
            var pay = new Employee
            {
                RegularHours = 20,
                OverTime = 20,
                OvertimeRate = 100,
                RegularRate = 100,
            };
            var expected = 4000;

            pay.CalculateGrossPay();
            var actual = pay.GrossPay;

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void CalculateSalaryIsCorrect()
        {
            //Arrange

            double RegularHours = 100;
            double OverTime = 20;
            double expected = 120;

            Employee emp = new Employee();

            //Act

              double actual = RegularHours + OverTime;

            //Assert
            Assert.Equal(actual, expected);

        }
    }


}