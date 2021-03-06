﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DoAn1
{
    class Provider
    {
        string ConnectionString { get; set; }
        public Provider(string str)
        {
            ConnectionString = str;
        }
        private ObservableCollection<string> GetDataSources()
        {
            string ServerName = Environment.MachineName;
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                var str = new ObservableCollection<string>();
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        string link = (ServerName + "\\" + instanceName);
                        str.Add(link);
                    }
                }
                return str;
            }
        }
        public Provider()
        {
            var strComputerName = GetDataSources();

            var loginName = PageLogin.acc.username;
            var pwd = PageLogin.acc.password;
            if (loginName == "admin")
            {
                if (strComputerName[0].Contains("\\MSSQLSERVER"))
                {
                    string ServerName = Environment.MachineName;
                    ConnectionString = $"Data Source={ServerName};Initial Catalog=MyStore;Integrated Security=True";
                }
                else
                {
                    ConnectionString = $"Data Source={strComputerName[0]};Initial Catalog=MyStore;Integrated Security=True";
                }
            }
            else
            {
                var buider = new SqlConnectionStringBuilder();
                buider.InitialCatalog = "MyStore";
                buider.UserID = loginName;
                buider.Password = pwd;

                if (strComputerName[0].Contains("\\MSSQLSERVER"))
                {
                    string ServerName = Environment.MachineName;
                    buider.DataSource = ServerName;
                    ConnectionString = $"{buider}";
                }
                else
                {
                    buider.DataSource = strComputerName[0];
                    ConnectionString = $"{buider}";
                }
            }
            
        }
        SqlConnection Connection { get; set; }
        public bool Connect()
        {
            try
            {
                if (Connection == null)
                    Connection = new SqlConnection(ConnectionString);
                if (Connection != null && Connection.State != ConnectionState.Closed)
                    Connection.Close();
                Connection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                return false;

            }
            return false;

        }

        public void DisConnect()
        {
            if (Connection != null && Connection.State == ConnectionState.Open)
                Connection.Close();
        }

        public int? ExcecuteNonQuery(CommandType cmtType, string sqlSQL,
                        params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand command = Connection.CreateCommand();
                command.CommandText = sqlSQL;
                command.CommandType = cmtType;
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);
                command.ExecuteNonQuery();
                int? nRow = command.Parameters["@id"].Value as int?;
                return nRow;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable ExcecuteQuery(CommandType cmtType, string strSQL,
                    params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand command = Connection.CreateCommand();
                command.CommandType = cmtType;
                command.CommandText = strSQL;
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        
    }
}
