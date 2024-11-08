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
    public partial class FormSignup : Form
    {
        public FormSignup()
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
                Customer akun = new Customer();
                akun.username = tbxUsername.Text;
                akun.setPassword(tbxPassword.Text);

                bool berhasilSignup = akun.signup(akun);
                if (berhasilSignup == true)
                {
                    MessageBox.Show("Berhasl signup!");
                }
                else
                {
                    MessageBox.Show("Username atau password anda salah, silahkan coba lagi!");
                }
            }

        }
    }
}
