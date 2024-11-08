using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBO_UTS.Classes;

namespace PBO_UTS.Classes
{
    internal class Customer : Akun
    {
        public bool signup(Akun akun)
        {
            string query = "INSERT INTO akun_customer (username, password) VALUES (@username, @password)";
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@username", akun.username),
                new NpgsqlParameter("@password", akun.getPassword())
            };
            try
            {
                DBService.commandExecutor(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan : {ex}");
                return false;
            }
        }
    }
}
