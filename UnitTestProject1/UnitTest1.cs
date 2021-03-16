using Day11UserRegistration;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstName()
        {
            Program program = new Program();
            bool result = program.validateFirstName("Sanjana");
            Assert.AreEqual(true, result);
        }
        public void TestInvalidFirstName()
        {
            Program program = new Program();
            bool result = program.validateFirstName("sanjana");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestLastName()
        {
            Program program = new Program();
            bool result = program.validateName("Sanjana");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestInvalidLastName()
        {
            Program program = new Program();
            bool result = program.validateName("sanju");
            Assert.AreEqual(false, result);
        }
    }

}

