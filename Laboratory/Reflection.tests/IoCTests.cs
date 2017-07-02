using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reflection.tests
{
    [TestClass]
    public class IoCTests
    {
        [TestMethod]
        public void Can_Resolve_types()
        {
            var ioc = new Container();
            // When anyone want an Ilogger please use an instance of SqlServerLogger
            ioc.For<Ilogger>().Use<SqlServerLogger>();

            // resolve something that implements the ILogger interface
            var logger = ioc.Resolve<Ilogger>();

            Assert.AreEqual(typeof(SqlServerLogger), logger.GetType());


        }
    }
}
