using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using OOP.Properties;
namespace OOP.Core
{
    internal static class ServerInstance
    {

        public static readonly string DbConnectionString = string.Format(
            "DataSource={0}; " +
            "Port={1}; " +
            "Database={2}; " +
            "UID={3}; " +
            "Password={4}; " +
            "UseCompression=True; " +
            "UseUsageAdvisor=True; " +
            "UsePerformanceMonitor=True; " +
            "Pooling=True;",
            Settings.Default.Server,
            Settings.Default.Port,
            Settings.Default.DB,
            Settings.Default.User,
            Settings.Default.Pass);

        private static readonly string dbConnectionService = DbConnectionString;
        public static readonly MySqlConnection dbConnection = new MySqlConnection(dbConnectionService);
    }
}
