using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;
using Sparcpoint.Business;
using Sparcpoint.SqlServer.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sparcpoint.Business.Tests
{
    [TestClass()]
    public class ProductLogicTests
    {
        ISqlExecutor _sqlExecutor;
        ILogger _logger;

        public ProductLogicTests(ISqlExecutor sqlExecutor, ILogger logger)
        {
            _sqlExecutor = sqlExecutor;
            _logger = logger;
        }

        public void InitializeValues()
        {
            //To Do: Make sure to initialize the Database.

        }

        [TestMethod()]
        public void AddProductToDBTest()
        {
            Assert.Fail();
        }
    }
}