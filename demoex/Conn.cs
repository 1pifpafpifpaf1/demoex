﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoex
{
    public class DataBase
    {
        public static MySqlConnection Conn { get => connection; set => connection = value; }
        public static MySqlConnection connection = new MySqlConnection("server=127.0.0.1;user=root;database=demoex;password=");
        public void OpenConnection()
        {
            if (Conn.State == System.Data.ConnectionState.Closed)
                Conn.Open();
        }
        public void CloseConnection()
        {
            if (Conn.State == System.Data.ConnectionState.Open)
                Conn.Close();
        }
        public MySqlConnection getConnection()
        {
            return Conn;
        }
    }
}
