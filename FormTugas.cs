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
    public partial class FormTugas : Form
    {
        public FormTugas()
        {
            InitializeComponent();
        }

        private void FormTugas_Load(object sender, EventArgs e)
        {
            try
            {
                dgvTugas.AllowUserToAddRows = false;

                DataTable src = Tabel.getAllData();
                dgvTugas.DataSource = src;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan : {ex}");
            }
        }
    }
}
