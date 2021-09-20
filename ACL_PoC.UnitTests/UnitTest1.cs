using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACL_PoC.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsNull(string.Empty);
        }
    }
}
