using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DBManager.Interfaces
{
    public interface IDBManager
    {
        DataTable GetData(string spName, Dictionary<string, object> parameters = null);
        object Insert(string spName, Dictionary<string, object> parameters);
        int UpdateOrDelete(string spName, Dictionary<string, object> parameters);
    }
}
