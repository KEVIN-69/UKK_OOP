namespace crudukk
{
    partial class CRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNamaBarang = new System.Windows.Forms.Label();
            this.textBoxNamaBarang = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelHargaBarang = new System.Windows.Forms.Label();
            this.labelStokBarang = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.labelClear = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxKategoriBarang = new System.Windows.Forms.TextBox();
            this.labelKategori = new System.Windows.Forms.Label();
            this.textBoxStokBarang = new System.Windows.Forms.TextBox();
            this.textBoxHargaBarang = new System.Windows.Forms.TextBox();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelKeluar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNamaBarang
            // 
            this.labelNamaBarang.AutoSize = true;
            this.labelNamaBarang.Font = new System.Drawing.Font("Airbnb Cereal App Book", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNamaBarang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNamaBarang.Location = new System.Drawing.Point(135, 55);
            this.labelNamaBarang.Name = "labelNamaBarang";
            this.labelNamaBarang.Size = new System.Drawing.Size(110, 21);
            this.labelNamaBarang.TabIndex = 0;
            this.labelNamaBarang.Text = "Nama Barang";
            // 
            // textBoxNamaBarang
            // 
            this.textBoxNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNamaBarang.Font = new System.Drawing.Font("Airbnb Cereal App Book", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNamaBarang.Location = new System.Drawing.Point(285, 50);
            this.textBoxNamaBarang.Multiline = true;
            this.textBoxNamaBarang.Name = "textBoxNamaBarang";
            this.textBoxNamaBarang.Size = new System.Drawing.Size(265, 26);
            this.textBoxNamaBarang.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(20, 416);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(726, 172);
            this.dataGridView.TabIndex = 3;
            // 
            // labelHargaBarang
            // 
            this.labelHargaBarang.AutoSize = true;
            this.labelHargaBarang.Font = new System.Drawing.Font("Airbnb Cereal App Book", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHargaBarang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHargaBarang.Location = new System.Drawing.Point(135, 128);
            this.labelHargaBarang.Name = "labelHargaBarang";
            this.labelHargaBarang.Size = new System.Drawing.Size(112, 21);
            this.labelHargaBarang.TabIndex = 5;
            this.labelHargaBarang.Text = "Harga Barang";
            // 
            // labelStokBarang
            // 
            this.labelStokBarang.AutoSize = true;
            this.labelStokBarang.Font = new System.Drawing.Font("Airbnb Cereal App Book", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStokBarang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStokBarang.Location = new System.Drawing.Point(135, 92);
            this.labelStokBarang.Name = "labelStokBarang";
            this.labelStokBarang.Size = new System.Drawing.Size(101, 21);
            this.labelStokBarang.TabIndex = 6;
            this.labelStokBarang.Text = "Stok Barang";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Crimson;
            this.panel.Controls.Add(this.labelClear);
            this.panel.Controls.Add(this.textBoxId);
            this.panel.Controls.Add(this.labelID);
            this.panel.Controls.Add(this.textBoxKategoriBarang);
            this.panel.Controls.Add(this.labelKategori);
            this.panel.Controls.Add(this.textBoxStokBarang);
            this.panel.Controls.Add(this.textBoxHargaBarang);
            this.panel.Controls.Add(this.labelNamaBarang);
            this.panel.Controls.Add(this.labelStokBarang);
            this.panel.Controls.Add(this.textBoxNamaBarang);
            this.panel.Controls.Add(this.labelHargaBarang);
            this.panel.Location = new System.Drawing.Point(20, 99);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(726, 206);
            this.panel.TabIndex = 8;
            // 
            // labelClear
            // 
            this.labelClear.AutoSize = true;
            this.labelClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClear.Font = new System.Drawing.Font("Airbnb Cereal App Book", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelClear.Location = new System.Drawing.Point(556, 167);
            this.labelClear.Name = "labelClear";
            this.labelClear.Size = new System.Drawing.Size(50, 21);
            this.labelClear.TabIndex = 19;
            this.labelClear.Text = "Clear";
            this.labelClear.Click += new System.EventHandler(this.labelClear_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxId.Font = new System.Drawing.Font("Airbnb Cereal App Book", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxId.Location = new System.Drawing.Point(285, 13);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(265, 26);
            this.textBoxId.TabIndex = 18;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Airbnb Cereal App Book", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelID.Location = new System.Drawing.Point(135, 18);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(81, 21);
            this.labelID.TabIndex = 17;
            this.labelID.Text = "Id Barang";
            // 
            // textBoxKategoriBarang
            // 
            this.textBoxKategoriBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKategoriBarang.Font = new System.Drawing.Font("Airbnb Cereal App Book", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxKategoriBarang.Location = new System.Drawing.Point(285, 162);
            this.textBoxKategoriBarang.Multiline = true;
            this.textBoxKategoriBarang.Name = "textBoxKategoriBarang";
            this.textBoxKategoriBarang.Size = new System.Drawing.Size(265, 26);
            this.textBoxKategoriBarang.TabIndex = 11;
            // 
            // labelKategori
            // 
            this.labelKategori.AutoSize = true;
            this.labelKategori.Font = new System.Drawing.Font("Airbnb Cereal App Book", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKategori.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelKategori.Location = new System.Drawing.Point(135, 167);
            this.labelKategori.Name = "labelKategori";
            this.labelKategori.Size = new System.Drawing.Size(132, 21);
            this.labelKategori.TabIndex = 10;
            this.labelKategori.Text = "Kategori Barang";
            // 
            // textBoxStokBarang
            // 
            this.textBoxStokBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStokBarang.Font = new System.Drawing.Font("Airbnb Cereal App Book", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxStokBarang.Location = new System.Drawing.Point(285, 87);
            this.textBoxStokBarang.Multiline = true;
            this.textBoxStokBarang.Name = "textBoxStokBarang";
            this.textBoxStokBarang.Size = new System.Drawing.Size(265, 26);
            this.textBoxStokBarang.TabIndex = 9;
            // 
            // textBoxHargaBarang
            // 
            this.textBoxHargaBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHargaBarang.Font = new System.Drawing.Font("Airbnb Cereal App Book", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHargaBarang.Location = new System.Drawing.Point(285, 123);
            this.textBoxHargaBarang.Multiline = true;
            this.textBoxHargaBarang.Name = "textBoxHargaBarang";
            this.textBoxHargaBarang.Size = new System.Drawing.Size(265, 26);
            this.textBoxHargaBarang.TabIndex = 8;
            // 
            // buttonView
            // 
            this.buttonView.BackColor = System.Drawing.Color.Crimson;
            this.buttonView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonView.FlatAppearance.BorderSize = 0;
            this.buttonView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonView.Font = new System.Drawing.Font("Airbnb Cereal App Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonView.ForeColor = System.Drawing.Color.White;
            this.buttonView.Location = new System.Drawing.Point(374, 311);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(112, 46);
            this.buttonView.TabIndex = 16;
            this.buttonView.Text = "Tampilkan";
            this.buttonView.UseVisualStyleBackColor = false;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Crimson;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Airbnb Cereal App Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(256, 311);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 46);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Hapus";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Crimson;
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Airbnb Cereal App Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(138, 311);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(112, 46);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Edit";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Crimson;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Airbnb Cereal App Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(20, 311);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(112, 46);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Simpan";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Crimson;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Airbnb Cereal App Book", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(631, 372);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(115, 38);
            this.buttonSearch.TabIndex = 12;
            this.buttonSearch.Text = "Cari";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Airbnb Cereal App Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Data Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Airbnb Cereal App Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fast Moving Goods Beta Mart";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(20, 372);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(590, 38);
            this.textBoxSearch.TabIndex = 20;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::crudukk.Properties.Resources.Logo_ukk_1;
            this.pictureBox.Location = new System.Drawing.Point(526, 40);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(220, 46);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 21;
            this.pictureBox.TabStop = false;
            // 
            // labelKeluar
            // 
            this.labelKeluar.AutoSize = true;
            this.labelKeluar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelKeluar.Font = new System.Drawing.Font("Airbnb Cereal App Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKeluar.ForeColor = System.Drawing.Color.Crimson;
            this.labelKeluar.Location = new System.Drawing.Point(677, 5);
            this.labelKeluar.Name = "labelKeluar";
            this.labelKeluar.Size = new System.Drawing.Size(69, 23);
            this.labelKeluar.TabIndex = 22;
            this.labelKeluar.Text = "Keluar";
            this.labelKeluar.Click += new System.EventHandler(this.labelKeluar_Click);
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(765, 600);
            this.Controls.Add(this.labelKeluar);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD UKK";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNamaBarang;
        private System.Windows.Forms.TextBox textBoxNamaBarang;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelHargaBarang;
        private System.Windows.Forms.Label labelStokBarang;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox textBoxKategoriBarang;
        private System.Windows.Forms.Label labelKategori;
        private System.Windows.Forms.TextBox textBoxStokBarang;
        private System.Windows.Forms.TextBox textBoxHargaBarang;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelClear;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelKeluar;
    }
}

