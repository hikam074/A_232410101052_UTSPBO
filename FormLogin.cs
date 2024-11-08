using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBO_UTS.Classes;

namespace PBO_UTS
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxUsername.Text) || string.IsNullOrEmpty(tbxPassword.Text))
            {
                MessageBox.Show("Silahkan lengkapi data terlebih dahulu!");
            }
            else
            {
                Admin akun = new Admin();
                akun.username = tbxUsername.Text;
                akun.setPassword(tbxPassword.Text);

                bool berhasilLogin = akun.login(akun);
                if (berhasilLogin == true)
                {
                    FormDashboard formDashboard = new FormDashboard();
                    formDashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau password anda salah, silahkan coba lagi!");
                }
            }
        }
    }
}
