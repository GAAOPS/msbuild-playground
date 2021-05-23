namespace HelloTest
{
    using HelloLibs;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTest1
    {
        private Greeting _greet;
        [TestMethod]
        public void TestMethod1()
        {
            Greeting greet = new Greeting { Greet = "Hallo" };

            Assert.AreEqual<string>(greet.Greet,"Hallo");
        }
    }
}
