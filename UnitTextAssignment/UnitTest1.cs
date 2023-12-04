using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTextAssignment
{
    [TestClass]
    public class UnitTest1
    {
        FunctionalTest.UnitTest_ReturnsAgbadevIfZero_ReturnString();

        [TestMethod]
        public string TestMethod1(int num)
        {
            if (num == 0)

            {
                return "dotNET";
            }
            else
            {
                return "agbadev";
            }
        }
    
    }
}
