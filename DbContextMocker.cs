using System;
using System.Collections.Generic;
using System.Text;
using awsomAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace awsomAPI.Tests
{
    public static class DbContextMocker
    {
        public static AwsomApiContext GetAwsomApiContext(string dbName)
        {
            var options = new DbContextOptionsBuilder<AwsomApiContext>()
                .UseInMemoryDatabase(databaseName: dbName)
                .Options;

            var dbContext = new AwsomApiContext(options);

            dbContext.Seed();

            return dbContext;
        }
    }
}
