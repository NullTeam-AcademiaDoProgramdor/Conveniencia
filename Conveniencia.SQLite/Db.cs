﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Conveniencia.SQLite
{
    class Db
    {
        private static SQLiteConnection sqliteConnection;

        public Db()
        {

        }

        private static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection(" "); // Atualizar connection string
            sqliteConnection.Open();
            return sqliteConnection;
        }


    }
}
