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
    public partial class FormRegister : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\kelas 12\UKK OOP\OPPUKK.accdb");
        public FormRegister()
        {
            InitializeComponent();
        }

        private void labelKembali_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.Show();
            this.Hide();
        }

        private void linkLabelClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBoxEmail.Clear();
            textBoxPassword.Text = "";
            textBoxUsername.Text = "";
            textBoxUsername.Focus();
        }

        private void buttonRegis_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Tidak boleh kosong");
            }
            else
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into admin values('" + textBoxUsername.Text + "','" + textBoxPassword.Text + "','" + textBoxEmail.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Akun berhasil Dibuat");
                FormLogin fl = new FormLogin();
                fl.Show();
                Close();

            }
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
