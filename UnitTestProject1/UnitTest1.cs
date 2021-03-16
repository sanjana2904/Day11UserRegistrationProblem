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
    }
    }
}
