using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestParse()
        {
            Assert.AreEqual(9, OOP_lab_1_2_1.Program.Parse(550));
        }
    }
}
