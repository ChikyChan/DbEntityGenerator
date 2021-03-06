using System;

using Xunit;

using DbEntityGenerator.Core.DataBaseInfoAccessor;
using DbEntityGenerator.Core.Model;
using DbEntityGenerator.Core.DataBaseInfoAccessor.SqlServer;

namespace DbEntityGenerator.Test
{
    public class DbInfoAccessorFactory_Test
    {
        [Fact]
        public void GetSqlServerInfoAccessorFactory_Test()
        {
            var server = ".,1433";
            var username = "ChikyChan";
            var password= "daxueJIAYOU01";

            var accessor = DbInfoAccessorFactory.GetDbInfoAccessor(DbType.SqlServer, server, username, password);

            Assert.True(accessor is SqlServerInfoAccessor);
        }
    }
}
