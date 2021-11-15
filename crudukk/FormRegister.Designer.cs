namespace crudukk
{
    partial class FormRegister
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
            this.labelKembali = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonRegis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.linkLabelClear = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKembali
            // 
            this.labelKembali.AutoSize = true;
            this.labelKembali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelKembali.Font = new System.Drawing.Font("Airbnb Cereal App Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKembali.Location = new System.Drawing.Point(12, 9);
            this.labelKembali.Name = "labelKembali";
            this.labelKembali.Size = new System.Drawing.Size(83, 23);
            this.labelKembali.TabIndex = 0;
            this.labelKembali.Text = "Kembali";
            this.labelKembali.Click += new System.EventHandler(this.labelKembali_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Airbnb Cereal App Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPassword.Location = new System.Drawing.Point(82, 284);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(89, 23);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Airbnb Cereal App Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEmail.Location = new System.Drawing.Point(82, 208);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(54, 23);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Airbnb Cereal App Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUsername.Location = new System.Drawing.Point(82, 136);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(94, 23);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Airbnb Cereal App Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.Black;
            this.textBoxUsername.Location = new System.Drawing.Point(86, 159);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(348, 37);
            this.textBoxUsername.TabIndex = 5;
            // 
            // buttonRegis
            // 
            this.buttonRegis.BackColor = System.Drawing.Color.Gold;
            this.buttonRegis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegis.FlatAppearance.BorderSize = 0;
            this.buttonRegis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegis.Font = new System.Drawing.Font("Airbnb Cereal App", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRegis.ForeColor = System.Drawing.Color.White;
            this.buttonRegis.Location = new System.Drawing.Point(152, 393);
            this.buttonRegis.Name = "buttonRegis";
            this.buttonRegis.Size = new System.Drawing.Size(213, 51);
            this.buttonRegis.TabIndex = 7;
            this.buttonRegis.Text = "DAFTAR";
            this.buttonRegis.UseVisualStyleBackColor = false;
            this.buttonRegis.Click += new System.EventHandler(this.buttonRegis_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Location = new System.Drawing.Point(0, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 53);
            this.panel1.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Airbnb Cereal App Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.Black;
            this.textBoxEmail.Location = new System.Drawing.Point(86, 231);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(348, 40);
            this.textBoxEmail.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Airbnb Cereal App Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.Location = new System.Drawing.Point(86, 307);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(348, 40);
            this.textBoxPassword.TabIndex = 10;
            // 
            // linkLabelClear
            // 
            this.linkLabelClear.AutoSize = true;
            this.linkLabelClear.Font = new System.Drawing.Font("Airbnb Cereal App Book", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabelClear.LinkColor = System.Drawing.Color.Gold;
            this.linkLabelClear.Location = new System.Drawing.Point(388, 360);
            this.linkLabelClear.Name = "linkLabelClear";
            this.linkLabelClear.Size = new System.Drawing.Size(50, 21);
            this.linkLabelClear.TabIndex = 11;
            this.linkLabelClear.TabStop = true;
            this.linkLabelClear.Text = "Clear";
            this.linkLabelClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClear_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::crudukk.Properties.Resources.Logo_ukk_1;
            this.pictureBox1.Location = new System.Drawing.Point(164, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 521);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabelClear);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRegis);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelKembali);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKembali;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonRegis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.LinkLabel linkLabelClear;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}