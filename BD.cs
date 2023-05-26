using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    internal class BD
    {
        NpgsqlConnection connect = new NpgsqlConnection("Server=localhost;Port=5432;Username=postgres;Password=123;Database=kursach_BD");
        public void OpenConnection()  // открытие соединения с БД
        {
            if(connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }
        }

        public void CloseConnection() // закрытие соединения с БД
        {
            if (connect.State == System.Data.ConnectionState.Open)
            {
                connect.Close();
            }
        }

        public NpgsqlConnection GetConnection() // возврат соединения
        {
            return connect;
        }
    }


}
