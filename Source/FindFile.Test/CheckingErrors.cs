using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindFile;

namespace Testing
{
    [TestClass]
    public class CheckingErrors
    {
        [TestMethod]
        public void SimpleMask1()
        {
            string mask = "Name='qwer'";
            Assert.AreEqual(true, CheckErrors.isMaskInRightFormat(mask));
        }

        [TestMethod]
        public void SimpleMask2()
        {
            string mask = "Length=10g";
            Assert.AreEqual(true, CheckErrors.isMaskInRightFormat(mask));
        }

        [TestMethod]
        public void SimpleMask3()
        {
            string mask = "Content~'Как же всё сложно'";
            Assert.AreEqual(true, CheckErrors.isMaskInRightFormat(mask));
        }

        [TestMethod]
        public void SimpleMask4()
        {
            string mask = "10<Length<=15'";
            Assert.AreEqual(true, CheckErrors.isMaskInRightFormat(mask));
        }

        [TestMethod]
        public void WrongSimpleMask1()
        {
            string mask = "Name     =   'wrong.txt'";
            Assert.AreEqual(false, CheckErrors.isMaskInRightFormat(mask));
        }

        [TestMethod]
        public void WrongSimpleMask2()
        {
            string mask = "Length= 15";
            Assert.AreEqual(false, CheckErrors.isMaskInRightFormat(mask));
        }

        [TestMethod]
        public void ComplexMask1()
        {
            string mask = "^(Name='qwer.txt')&(Length=13)";
            Assert.AreEqual(true, CheckErrors.isMaskInRightFormat(mask));
        }

        [TestMethod]
        public void ComplexMask2()
        {
            string mask = "(Name='qwer.txt')^(Content~'qqw')";
            Assert.AreEqual(true, CheckErrors.isMaskInRightFormat(mask));
        }

    }
}
