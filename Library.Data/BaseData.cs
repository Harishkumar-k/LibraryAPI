using Library.Contract.Data;
using Library.Contract.Framework;
using System.Data;
using System.Data.SqlClient;

namespace Library.Data
{
    public class BaseData : IData
    {
        public string connectionString { get; set; }
        public IAppsetting DbConnectionSetting { get; }

        public BaseData(IAppsetting dbConnectionSetting)
        {
            DbConnectionSetting = dbConnectionSetting;
            this.DetermineConnection(dbConnectionSetting);
        }

        private void SetConnectionString(string ConnectionString)
        {
            this.connectionString = ConnectionString;
        }

        public void DetermineConnection(IAppsetting dbConnectionSetting)
        {
            this.SetConnectionString(DbConnectionSetting.Connection_string);
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(this.connectionString);
        }
    }
}
