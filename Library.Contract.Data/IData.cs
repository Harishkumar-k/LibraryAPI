using Library.Contract.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Library.Contract.Data
{
    public interface IData
    {
        void DetermineConnection(IAppsetting dbConnectionSetting);
        SqlConnection GetConnection();
    }
}
