using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_UTS.Classes
{
    public static class Tabel
    {
        public static DataTable getAllData()
        {
            string query = "SELECT * FROM tugas";
            try
            {
                DataTable result = DBService.queryExecutor(query);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan : {ex}");
                return null;
            }
        }
    }

}
