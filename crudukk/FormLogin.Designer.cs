namespace crudukk
{
    partial class FormLogin
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelKeluar = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelRegis = new System.Windows.Forms.LinkLabel();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.linkLabelClear = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Airbnb Cereal App Book", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUsername.Location = new System.Drawing.Point(34, 136);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(84, 21);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Airbnb Cereal App Book", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPassword.Location = new System.Drawing.Point(34, 223);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(81, 21);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // labelKeluar
            // 
            this.labelKeluar.AutoSize = true;
            this.labelKeluar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelKeluar.Font = new System.Drawing.Font("Airbnb Cereal App Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKeluar.ForeColor = System.Drawing.Color.Black;
            this.labelKeluar.Location = new System.Drawing.Point(12, 9);
            this.labelKeluar.Name = "labelKeluar";
            this.labelKeluar.Size = new System.Drawing.Size(69, 23);
            this.labelKeluar.TabIndex = 2;
            this.labelKeluar.Text = "Keluar";
            this.labelKeluar.Click += new System.EventHandler(this.labelKeluar_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Gold;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Airbnb Cereal App Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(178, 346);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(142, 49);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "MASUK";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.linkLabelRegis);
            this.panel1.Location = new System.Drawing.Point(-10, 451);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 79);
            this.panel1.TabIndex = 4;
            // 
            // linkLabelRegis
            // 
            this.linkLabelRegis.AutoSize = true;
            this.linkLabelRegis.Font = new System.Drawing.Font("Airbnb Cereal App Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabelRegis.LinkColor = System.Drawing.Color.White;
            this.linkLabelRegis.Location = new System.Drawing.Point(127, 27);
            this.linkLabelRegis.Name = "linkLabelRegis";
            this.linkLabelRegis.Size = new System.Drawing.Size(271, 23);
            this.linkLabelRegis.TabIndex = 8;
            this.linkLabelRegis.TabStop = true;
            this.linkLabelRegis.Text = "Belum punya akun? Daftar disini";
            this.linkLabelRegis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegis_LinkClicked);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Airbnb Cereal App Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.Black;
            this.textBoxUsername.Location = new System.Drawing.Point(38, 160);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(418, 41);
            this.textBoxUsername.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Airbnb Cereal App Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.Location = new System.Drawing.Point(38, 247);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(418, 39);
            this.textBoxPassword.TabIndex = 6;
            // 
            // linkLabelClear
            // 
            this.linkLabelClear.AutoSize = true;
            this.linkLabelClear.Font = new System.Drawing.Font("Airbnb Cereal App Book", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabelClear.LinkColor = System.Drawing.Color.Gold;
            this.linkLabelClear.Location = new System.Drawing.Point(410, 301);
            this.linkLabelClear.Name = "linkLabelClear";
            this.linkLabelClear.Size = new System.Drawing.Size(50, 21);
            this.linkLabelClear.TabIndex = 7;
            this.linkLabelClear.TabStop = true;
            this.linkLabelClear.Text = "Clear";
            this.linkLabelClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClear_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::crudukk.Properties.Resources.Logo_ukk_1;
            this.pictureBox1.Location = new System.Drawing.Point(145, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 521);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabelClear);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelKeluar);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelKeluar;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabelRegis;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.LinkLabel linkLabelClear;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}