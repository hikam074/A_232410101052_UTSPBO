using Npgsql;
using PBO_UTS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_UTS
{
    public partial class FormAddTugas : Form
    {
        public FormAddTugas()
        {
            InitializeComponent();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            FormTugas formTugas = new FormTugas();
            formTugas.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxJudul.Text) || (string.IsNullOrEmpty(tbxDesc.Text) || string.IsNullOrEmpty((DateOnly.Parse(dtpDL.Value.ToShortDateString())).ToString())))
            {
                MessageBox.Show("Lengkapi data!");
            }
            else
            {
                string query = "INSERT INTO tugas (judul_tugas, deskripsi, deadline) VALUES (@judul_tugas, @deskripsi, @deadline)";
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                
                {
                new NpgsqlParameter("@judul_tugas", tbxJudul.Text),
                new NpgsqlParameter("@deskripsi", tbxDesc.Text),
                new NpgsqlParameter("@deadline", dtpDL.Value)
                };
                try
                {
                    DBService.commandExecutor(query, parameters);
                    MessageBox.Show("Data berhasil ditambahkan");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan : {ex}");
                }
                finally
                {
                    FormTugas formTugas = new FormTugas();
                    formTugas.Show();
                    this.Hide();
                }
                
            }
        }
    }
}
