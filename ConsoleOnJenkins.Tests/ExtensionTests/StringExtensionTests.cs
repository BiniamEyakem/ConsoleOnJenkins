using ConsoleOnJenkins.Extensions;
using ConsoleOnJenkins.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleOnJenkins.Tests.ExtensionTests
{
    [TestClass]
    public class StringExtensionTests
    {
        [TestMethod]
        public void ToTypfOfTTest()
        {
            var personJson = "{'Id':1,'Name':'Josh'}";
            var person = personJson.ToTypeOfT<Person>();

            Assert.IsNotNull(person);
            Assert.IsInstanceOfType(person, typeof(Person));
        }
    }
}
