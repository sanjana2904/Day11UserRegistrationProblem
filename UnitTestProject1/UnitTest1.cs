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
        [TestMethod]
        public void TestEmailName()
        {
            Program program = new Program();
            bool result = program.validateEmail("sanju@gmail.com");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestInValidEmailName()
        {
            Program program = new Program();
            bool result = program.validateEmail("sanjugmail.com");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestValidPhoneNumber()
        {
            Program program = new Program();
            bool result = program.validatePhoneNumber("91 7708796223");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestInValidPhoneNumber()
        {
            Program program = new Program();
            bool result = program.validatePhoneNumber("917708796223");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestValidPassword()
        {
            Program program = new Program();
            bool result = program.validatePassword("sanjanaks");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestInValidPassword()
        {
            Program program = new Program();
            bool result = program.validatePassword("sanjana");
            Assert.AreEqual(false, result);
        }
    }

}

