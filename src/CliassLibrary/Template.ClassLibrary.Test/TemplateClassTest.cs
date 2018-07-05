using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Template.ClassLibrary.Test
{
    [TestClass]
    public class TemplateClassTest
    {
        [TestMethod]
        public void GreetMessageTest()
        {
            Assert.AreEqual("Hello world!", TemplateClass.GreetMessage);
        }
    }
}