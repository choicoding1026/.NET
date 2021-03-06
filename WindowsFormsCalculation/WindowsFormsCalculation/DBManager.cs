﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCalculation
{
    class DBManager
    {
        public OracleConnection connection;

        /// <summary>
        /// db 연결 및 insert
        /// </summary>
        /// <param name="fileName">파일명</param>
        /// <param name="expression">수식</param>
        public void dbConncetor(string fileName, string expression)
        {
            connection = new OracleConnection();

            /// 외부 DB
            ///
            /// connection.ConnectionString = @"Data Source=(DESCRIPTION="
            ///                            + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=WIN-7ESCJJPSMMC)(PORT=1521)))"
            ///                            + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVER_NAME=XE)));"
            ///                            + "User Id=test;Password=test;";
            
            /// 내부 DB
            connection.ConnectionString = @"Data Source=(DESCRIPTION="
                                        + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))"
                                        + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVER_NAME=XE)));"
                                        + "User Id=test1;Password=test1;";
                                        
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;

            string insertSql = string.Format("INSERT INTO CALCULATE VALUES ('{0}','{1}')", fileName, expression);

            cmd.CommandText = insertSql;
            cmd.ExecuteNonQuery();

            connection.Close();
        }


    }
}
