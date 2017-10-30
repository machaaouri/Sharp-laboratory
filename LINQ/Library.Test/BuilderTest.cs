using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Library.Test
{
    [TestClass]
    public class BuilderTest
    {
        public TestContext TestContext { get; set; }


        [TestMethod]
        public void BuildIntegerSequenceTest()
        {
            Builder builder = new Builder();

            var integers = builder.BuildIntegerSequence();

            //analyze
            foreach(var item in integers)
            {
                TestContext.WriteLine(item.ToString());
            }

            //Assert
            Assert.IsNotNull(integers);
        }

        [TestMethod]
        public void BuildStringSequenceTest()
        {
            Builder builder = new Builder();

            var strings = builder.BuildStringSequence();

            //analyze
            foreach (var item in strings)
            {
                TestContext.WriteLine(item.ToString());
            }

            //Assert
            Assert.IsNotNull(strings);
        }

        [TestMethod]
        public void CompareSequenceTest()
        {
            Builder builder = new Builder();

            var result = builder.CompareSequence();

            //analyze
            foreach (var item in result)
            {
                TestContext.WriteLine(item.ToString());
            }

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
