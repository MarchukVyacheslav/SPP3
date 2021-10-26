using Microsoft.VisualStudio.TestTools.UnitTesting;
using AssemblyBrowserLib;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTests
    {
        private readonly AssemblyBrowser _browser = new AssemblyBrowser();
        private const string TestDirectory = "E:\\Documents\\University\\Марчук 951004\\3 курс\\5 семестр\\СПП\\Лабораторные работы\\SPP3\\AssemblyBrowser\\View\\bin\\Debug\\";

        [TestMethod]
        public void DllBrowserWorkFinishedCorrectly()
        {
            _browser.GetAssemblyInfo(TestDirectory + "AssemblyBrowserLib.dll");

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void ExeBrowserWorkFinishedCorrectly()
        {
            _browser.GetAssemblyInfo(TestDirectory + "View.exe");

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void NameSpaceIsCorrect()
        {
            var assemblyInfo = _browser.GetAssemblyInfo(TestDirectory + "AssemblyBrowserLib.dll");
            ;
            Assert.IsTrue(assemblyInfo[0].Signature.Equals("AssemblyBrowserLib"));
            Assert.IsTrue(assemblyInfo[1].Signature.Equals("AssemblyBrowserLib.Format"));
        }

        [TestMethod]
        public void MethodNotNull()
        {
            var assemblyInfo = _browser.GetAssemblyInfo(TestDirectory + "View.exe");
            ;
            Assert.IsNotNull(assemblyInfo[1].Members);
        }
    }
}
