using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using System.Data;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;
using NLog.Internal;
using System.Xml.Linq;
using System.Diagnostics;
namespace DAL
{
    public class DataBaseM
    {
        SqlConnection SqlCN;
        SqlCommand sqlCmd;
        SqlDataAdapter DA;
        DataTable DT;

        public DataBaseM()
        {
            try
            {
                SqlCN = new();
                SqlCN.ConnectionString = ConfigurationManager.ConnectionStrings["pubsCN"].ConnectionString;
                sqlCmd = new(string.Empty, SqlCN);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                DA = new(sqlCmd);
                DT = new();
            }
            catch (Exception Ex)
            {
                Trace.WriteLine($"An error ocurred ex.message{Ex.Message}");

            }
        }
        public DataTable ExecuteDataTable(string SPName)
        {
            try
            {
                sqlCmd.Parameters.Clear();
                DT.Clear();
                sqlCmd.CommandText = SPName;
                DA = new(sqlCmd);
                DA.Fill(DT);
                return DT;
            }
            catch(Exception ex)
            {
                Trace.WriteLine($"An error occurred while loading Data: {ex.Message}");
            }
            return new(); //if error thrown
        }
        public object ExecuteScalar(string SPName)
        {
            try
            {
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = SPName;

                if (SqlCN.State == ConnectionState.Closed)
                {
                    SqlCN.Open();
                }

                return sqlCmd.ExecuteScalar();
            }catch(Exception ex)
            {
                Trace.WriteLine($"An error occurred while loading Data: {ex.Message}");
            }
            finally
            {
                SqlCN.Close();
            }
            return new();
        }
        public int ExecuteNonQuery(string SPName)
        {
            try
            {
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = SPName;

                if (SqlCN.State == ConnectionState.Closed)
                {
                    SqlCN.Open();
                }

                return sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Trace.WriteLine($"An error occurred while loading Data: {ex.Message}");
            }
            finally
            {
                SqlCN.Close();
            }
            return -1;
        }
        public DataTable ExecuteDataTable(string SPName,Dictionary <string,object>Parameters)
        {
            try
            {
                sqlCmd.Parameters.Clear();
                DT.Clear();
                sqlCmd.CommandText = SPName;
                foreach (var Parameter in Parameters){
                    sqlCmd.Parameters.Add(new(Parameter.Key, Parameter.Value));
                }
                DA = new(sqlCmd);
                DA.Fill(DT);
                return DT;
            }
            catch (Exception ex)
            {
                Trace.WriteLine($"An error occurred while loading Data: {ex.Message}");
            }
            return new(); //if error thrown
        }
        public object ExecuteScalar(string SPName,Dictionary<string,object>Parameters)
        {
            try
            {
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = SPName;
                foreach (var Parameter in Parameters)
                {
                    sqlCmd.Parameters.Add(new(Parameter.Key, Parameter.Value));
                }
                if (SqlCN.State == ConnectionState.Closed)
                {
                    SqlCN.Open();
                }

                return sqlCmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Trace.WriteLine($"An error occurred while loading Data: {ex.Message}");
            }
            finally
            {
                SqlCN.Close();
            }
            return new();
        }
        public int ExecuteNonQuery(string SPName,Dictionary<string,object>Parameters)
        {
            try
            {

                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = SPName;
                if (SqlCN.State == ConnectionState.Closed)
                {
                    SqlCN.Open();
                }
                foreach (var Parameter in Parameters)
                {
                    sqlCmd.Parameters.Add(new(Parameter.Key, Parameter.Value));
                }
               
                return sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Trace.WriteLine($"An error occurred while loading Data: {ex.Message}");
            }
            finally
            {
                SqlCN.Close();
            }
            return -1;
        }

    }
}
