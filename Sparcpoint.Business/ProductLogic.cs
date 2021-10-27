using NLog;
using Sparcpoint.Models;
using Sparcpoint.SqlServer.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sparcpoint.Business
{
    public interface IProductLogic
    {
        bool AddProductToDB(Products product);
    }

    public class ProductLogic : IProductLogic
    {
        ISqlExecutor _sqlExecutor;
        ILogger _logger;
        public ProductLogic(ISqlExecutor sqlExecutor, ILogger logger)
        {
            _sqlExecutor = sqlExecutor;
            _logger = logger;
        }

        public bool AddProductToDB(Products product)
        {
            _logger.Debug("Adding Product to the Database");
            //TO DO: Add Sqlexecutor.ExecuteAsync to this
            throw new NotImplementedException();
        }
    }
}
