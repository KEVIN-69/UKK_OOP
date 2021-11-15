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
    public partial class CRUD : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\kelas 12\UKK OOP\OPPUKK.accdb");
        int count = 0;
        public CRUD()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxNamaBarang.Text == "" || textBoxStokBarang.Text == "" || textBoxHargaBarang.Text == "" || textBoxKategoriBarang.Text == "")
            {
                MessageBox.Show("Jangan dikosongkan");
            }
            else
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into databarang (Nama_barang,Stok_barang,Harga_barang,Kategori_barang) values('" + textBoxNamaBarang.Text + "','" + textBoxStokBarang.Text + "','" + textBoxHargaBarang.Text + "','" + textBoxKategoriBarang.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    textBoxNamaBarang.Text = "";
                    textBoxStokBarang.Text = "";
                    textBoxHargaBarang.Text = "";
                    textBoxKategoriBarang.Text = "";
                    MessageBox.Show("Barang berhasil ditambah");
                }catch(Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from databarang";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "")
            {
                MessageBox.Show("Jangan dikosongkan");
            }
            else
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    string query = "delete from databarang where ID=" + textBoxId.Text + "";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    textBoxId.Text = "";
                    MessageBox.Show("Barang berhasil dihapus");
                }catch(Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxNamaBarang.Text == "" || textBoxStokBarang.Text == "" || textBoxHargaBarang.Text == "" || textBoxKategoriBarang.Text == "")
            {
                MessageBox.Show("Jangan dikosongkan");
            }
            else {
                try
                {
                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    string query = "update databarang set Nama_barang='" + textBoxNamaBarang.Text + "' ,Stok_barang='" + textBoxStokBarang.Text + "' ,Harga_barang='" + textBoxHargaBarang.Text + "' ,Kategori_barang='" + textBoxKategoriBarang.Text + "' where ID=" + textBoxId.Text + "";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    textBoxId.Text = "";
                    textBoxNamaBarang.Text = "";
                    textBoxStokBarang.Text = "";
                    textBoxHargaBarang.Text = "";
                    textBoxKategoriBarang.Text = "";
                    MessageBox.Show("Barang berhasil diedit");
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message);
                }
             }
        }

        private void labelClear_Click(object sender, EventArgs e)
        {
            textBoxId.Clear();
            textBoxNamaBarang.Clear();
            textBoxStokBarang.Clear();
            textBoxHargaBarang.Clear();
            textBoxKategoriBarang.Clear();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            count = 0;
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from databarang where Kategori_barang='"+textBoxSearch.Text+"' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridView.DataSource = dt;
            con.Close();
            

            if (count == 0)
            {
                MessageBox.Show("Barang tidak ditemukan");
            }
        }

        private void labelKeluar_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.Show();
            this.Close();
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
