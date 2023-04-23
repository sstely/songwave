namespace MuzicaOnline
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.bdDataSet = new MuzicaOnline.bdDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new MuzicaOnline.bdDataSetTableAdapters.usersTableAdapter();
            this.lbRegister = new System.Windows.Forms.Label();
            this.lbInfo1 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.CheckBxShowPass = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsernameEmail = new System.Windows.Forms.Label();
            this.lbHead = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bdDataSet
            // 
            this.bdDataSet.DataSetName = "bdDataSet";
            this.bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.bdDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.lbRegister.Location = new System.Drawing.Point(99, 413);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(88, 17);
            this.lbRegister.TabIndex = 36;
            this.lbRegister.Text = "Creeaza Cont";
            this.lbRegister.Click += new System.EventHandler(this.lbRegister_Click);
            // 
            // lbInfo1
            // 
            this.lbInfo1.AutoSize = true;
            this.lbInfo1.Location = new System.Drawing.Point(79, 391);
            this.lbInfo1.Name = "lbInfo1";
            this.lbInfo1.Size = new System.Drawing.Size(134, 17);
            this.lbInfo1.TabIndex = 37;
            this.lbInfo1.Text = "Nu Am Inca Un Cont";
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.White;
            this.btClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btClear.Location = new System.Drawing.Point(38, 329);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(216, 35);
            this.btClear.TabIndex = 34;
            this.btClear.Text = "GOLIRE";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.ForeColor = System.Drawing.Color.White;
            this.btLogin.Location = new System.Drawing.Point(38, 279);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(216, 35);
            this.btLogin.TabIndex = 35;
            this.btLogin.Text = "LOGARE";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // CheckBxShowPass
            // 
            this.CheckBxShowPass.AutoSize = true;
            this.CheckBxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBxShowPass.Location = new System.Drawing.Point(150, 240);
            this.CheckBxShowPass.Name = "CheckBxShowPass";
            this.CheckBxShowPass.Size = new System.Drawing.Size(100, 21);
            this.CheckBxShowPass.TabIndex = 33;
            this.CheckBxShowPass.Text = "Arata Parola";
            this.CheckBxShowPass.UseVisualStyleBackColor = true;
            this.CheckBxShowPass.CheckedChanged += new System.EventHandler(this.CheckBxShowPass_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(38, 197);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(216, 28);
            this.txtPassword.TabIndex = 31;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(38, 132);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(216, 28);
            this.txtUsername.TabIndex = 32;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(35, 177);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(47, 17);
            this.lbPassword.TabIndex = 29;
            this.lbPassword.Text = "Parola";
            // 
            // lbUsernameEmail
            // 
            this.lbUsernameEmail.AutoSize = true;
            this.lbUsernameEmail.Location = new System.Drawing.Point(35, 112);
            this.lbUsernameEmail.Name = "lbUsernameEmail";
            this.lbUsernameEmail.Size = new System.Drawing.Size(132, 17);
            this.lbUsernameEmail.TabIndex = 30;
            this.lbUsernameEmail.Text = "Username sau Email";
            // 
            // lbHead
            // 
            this.lbHead.AutoSize = true;
            this.lbHead.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.lbHead.Location = new System.Drawing.Point(33, 60);
            this.lbHead.Name = "lbHead";
            this.lbHead.Size = new System.Drawing.Size(154, 27);
            this.lbHead.TabIndex = 28;
            this.lbHead.Text = "Sa incepem";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(257, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(289, 489);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbRegister);
            this.Controls.Add(this.lbInfo1);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.CheckBxShowPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsernameEmail);
            this.Controls.Add(this.lbHead);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logare";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bdDataSet bdDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private bdDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label lbRegister;
        private System.Windows.Forms.Label lbInfo1;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.CheckBox CheckBxShowPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsernameEmail;
        private System.Windows.Forms.Label lbHead;
        private System.Windows.Forms.Button button1;

    }
}

