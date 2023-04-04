using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace ConsoleOnJenkins.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void NamedGreeetingTest()
        {
            const string name = "Josh";
            string Expected = $"Hello {name}!";
            
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                ConsoleOnJenkins.Program.Main(new string[] { name });

                var response = sw.ToString().Trim();
                Assert.AreEqual(Expected, response);
            }
        }

        [TestMethod]
        public void GuestGrertingTest()
        {            
            string Expected = $"Hello Guest!";

            using(var sw = new StringWriter())
            {
                Console.SetOut(sw);
                ConsoleOnJenkins.Program.Main(new string[] { string.Empty });
                var response = sw.ToString().Trim();
                Assert.AreEqual(response, Expected);
            }
        }
    }
}
