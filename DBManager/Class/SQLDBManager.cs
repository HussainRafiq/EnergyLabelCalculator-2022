using DBManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlTypes;
using System.Text;

namespace DBManager.Class
{
    public class SQLDBManager : IDBManager
    {

        private IDbConnection connection;

        public SQLDBManager(IDbConnection con)
        {
            connection = con;
        }
        private IDbCommand PrepareCommand(string spName, Dictionary<string, object> parameters = null)
        {
            try
            {


                IDbCommand command;

                command = connection.CreateCommand();
                command.CommandText = spName;
                command.CommandType = CommandType.StoredProcedure;

                if (parameters != null && parameters.Count > 0)
                {

                    
                    foreach ( var key in  parameters.Keys)
                    {
                        var parameter = command.CreateParameter();
                        parameter.ParameterName = key;
                        parameter.Value = parameters[key];
                        command.Parameters.Add(parameter);
                    }
                }
                return command;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetData(string spName, Dictionary<string, object> parameters = null)
        {
            try
            {
                
                connection.Open();

                var cmd = this.PrepareCommand(spName, parameters);

                var reader = cmd.ExecuteReader();

                DataTable result = new DataTable();
                result.Load(reader);

                return result;

            }
            catch (Exception ex)
            {
                // TODO: log exception
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public object Insert(string spName, Dictionary<string, object> parameters)
        {

            try
            {
                connection.Open();

                var cmd = this.PrepareCommand(spName, parameters);

                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                // TODO: log exception
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public int UpdateOrDelete(string spName, Dictionary<string, object> parameters)
        {
            try
            {
                connection.Open();

                var cmd = this.PrepareCommand(spName, parameters);

                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // TODO: log exception
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        
    }
}
