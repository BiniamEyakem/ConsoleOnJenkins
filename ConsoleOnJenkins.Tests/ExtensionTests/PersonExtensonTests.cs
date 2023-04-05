using ConsoleOnJenkins.Extensions;
using ConsoleOnJenkins.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleOnJenkins.Tests.ExtensionTests
{
    [TestClass]
    public class PersonExtensonTests
    {
        [TestMethod]
        public void ToJsonStringTest()
        {
            var person = new Person { Id = 1, Name = "Josh" };
            var jsonPerson = person.ToJsonString();
            Assert.IsInstanceOfType(jsonPerson, typeof(String));
            Assert.IsTrue(jsonPerson.Contains(person.Name));
        }
    }
}
