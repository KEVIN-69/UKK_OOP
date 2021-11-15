using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace crudukk
{
    public partial class FormLogin : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\kelas 12\UKK OOP\OPPUKK.accdb");
        public FormLogin()
        {
            InitializeComponent();
        }

        private void labelKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBoxPassword.Clear();
            textBoxUsername.Text = "";
            textBoxUsername.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxHidden_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select count(*) from admin where nama_admin='" + textBoxUsername.Text + "'and password_admin='" + textBoxPassword.Text + "'", con);

            // buat data tabel
            DataTable dt = new DataTable();

            //fill data tabel
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                // means the username and password is correct
                CRUD fc = new CRUD();
                fc.Show();
                this.Hide();

            }
            else
            {
                //means the username or password is incorrect
                MessageBox.Show("Gagal Login, Coba lagi !");
            }
        }

        private void linkLabelRegis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister fr = new FormRegister();
            fr.Show();
            this.Hide();
        }
    }
}
