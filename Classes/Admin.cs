using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PBO_UTS.Classes
{
    internal class Admin : Akun
    {

        public bool login(Akun akun)
        {
            string query = "SELECT COUNT(*) FROM akun_admin WHERE username  = @username AND password = @password";
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@username", akun.username),
                new NpgsqlParameter("@password", akun.getPassword())
            };
            try
            {
                DataTable result = DBService.queryExecutor(query, parameters);
                int counted = Convert.ToInt32(result.Rows[0][0]);
                return counted > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan : {ex}");
                return false;
            }
        }
    }
}
