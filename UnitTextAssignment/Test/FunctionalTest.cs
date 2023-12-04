using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTextAssignment.Test
{
    public class FunctionalTest
    {
        //NamingConvention: ClassName_MethodName_ExpectedResult.

        public static void UnitTest_ReturnsAgbadevIfZero_ReturnString()
        {
            try
            {
                //Arrange
                int num = 0;
                UnitTest1 unitTest1 = new UnitTest1();



                //Act
                string result = unitTest1.ToString();

                //Assert
                if (result == "dotNET")
                {
                    Console.WriteLine("PASSED :  UnitTest_ReturnsAgbadevIfZero_ReturnString");
                }
                else
                {
                    Console.WriteLine("FAILED");
                }

                

            }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}
