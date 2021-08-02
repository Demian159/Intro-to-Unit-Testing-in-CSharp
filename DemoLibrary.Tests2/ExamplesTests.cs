using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DemoLibrary;
using System.IO;

namespace DemoLibrary.Tests2
{
    public class ExamplesTests
    {
        [Fact]
        public void ExampleLoadTextFile_ValidNameShouldWork()
        {
            //Arrange

            //Action
            string actual = Examples.ExampleLoadTextFile("This is a valid file name.");

            //Assert
            Assert.True(actual.Length > 0);
        }
        [Fact]
        public void ExampleLoadTextFile_InvalidNameShouldFail()
        {
            //Arrange

            //Action
            string actual = Examples.ExampleLoadTextFile("This is a valid file name.");

            //Assert
            Assert.Throws<ArgumentException>("file",() => Examples.ExampleLoadTextFile(""));
        }
    }
}
