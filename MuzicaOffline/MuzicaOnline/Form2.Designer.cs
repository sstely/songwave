namespace MuzicaOnline
{
    partial class frmRegister
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.lbBackLogin = new System.Windows.Forms.Label();
            this.lbInfo1 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.btRegister = new System.Windows.Forms.Button();
            this.CheckBxShowPass = new System.Windows.Forms.CheckBox();
            this.txtComPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbComPassword = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbHead = new System.Windows.Forms.Label();
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
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.lblMessage.Location = new System.Drawing.Point(30, 94);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 23;
            // 
            // lbBackLogin
            // 
            this.lbBackLogin.AutoSize = true;
            this.lbBackLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBackLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.lbBackLogin.Location = new System.Drawing.Point(84, 549);
            this.lbBackLogin.Name = "lbBackLogin";
            this.lbBackLogin.Size = new System.Drawing.Size(116, 17);
            this.lbBackLogin.TabIndex = 20;
            this.lbBackLogin.Text = "Inapoi la LOGARE";
            this.lbBackLogin.Click += new System.EventHandler(this.lbBackLogin_Click);
            // 
            // lbInfo1
            // 
            this.lbInfo1.AutoSize = true;
            this.lbInfo1.Location = new System.Drawing.Point(83, 527);
            this.lbInfo1.Name = "lbInfo1";
            this.lbInfo1.Size = new System.Drawing.Size(115, 17);
            this.lbInfo1.TabIndex = 21;
            this.lbInfo1.Text = "Am Deja Un Cont";
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.White;
            this.btClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btClear.Location = new System.Drawing.Point(33, 465);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(216, 35);
            this.btClear.TabIndex = 18;
            this.btClear.Text = "GOLIRE";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRegister.FlatAppearance.BorderSize = 0;
            this.btRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegister.ForeColor = System.Drawing.Color.White;
            this.btRegister.Location = new System.Drawing.Point(33, 415);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(216, 35);
            this.btRegister.TabIndex = 19;
            this.btRegister.Text = "INREGISTRARE";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // CheckBxShowPass
            // 
            this.CheckBxShowPass.AutoSize = true;
            this.CheckBxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBxShowPass.Location = new System.Drawing.Point(145, 376);
            this.CheckBxShowPass.Name = "CheckBxShowPass";
            this.CheckBxShowPass.Size = new System.Drawing.Size(100, 21);
            this.CheckBxShowPass.TabIndex = 17;
            this.CheckBxShowPass.Text = "Arata Parola";
            this.CheckBxShowPass.UseVisualStyleBackColor = true;
            this.CheckBxShowPass.CheckedChanged += new System.EventHandler(this.CheckBxShowPass_CheckedChanged);
            // 
            // txtComPassword
            // 
            this.txtComPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtComPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComPassword.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComPassword.Location = new System.Drawing.Point(33, 339);
            this.txtComPassword.Multiline = true;
            this.txtComPassword.Name = "txtComPassword";
            this.txtComPassword.PasswordChar = '•';
            this.txtComPassword.Size = new System.Drawing.Size(216, 28);
            this.txtComPassword.TabIndex = 16;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(33, 274);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(216, 28);
            this.txtPassword.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(33, 209);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 28);
            this.txtEmail.TabIndex = 14;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(33, 144);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(216, 28);
            this.txtUsername.TabIndex = 15;
            // 
            // lbComPassword
            // 
            this.lbComPassword.AutoSize = true;
            this.lbComPassword.Location = new System.Drawing.Point(30, 319);
            this.lbComPassword.Name = "lbComPassword";
            this.lbComPassword.Size = new System.Drawing.Size(108, 17);
            this.lbComPassword.TabIndex = 10;
            this.lbComPassword.Text = "Confirma Parola";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(30, 254);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(47, 17);
            this.lbPassword.TabIndex = 9;
            this.lbPassword.Text = "Parola";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(30, 189);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(42, 17);
            this.lbEmail.TabIndex = 12;
            this.lbEmail.Text = "Email";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(30, 124);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(69, 17);
            this.lbUsername.TabIndex = 11;
            this.lbUsername.Text = "Username";
            // 
            // lbHead
            // 
            this.lbHead.AutoSize = true;
            this.lbHead.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.lbHead.Location = new System.Drawing.Point(28, 45);
            this.lbHead.Name = "lbHead";
            this.lbHead.Size = new System.Drawing.Size(154, 27);
            this.lbHead.TabIndex = 8;
            this.lbHead.Text = "Sa incepem";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 613);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lbBackLogin);
            this.Controls.Add(this.lbInfo1);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.CheckBxShowPass);
            this.Controls.Add(this.txtComPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbComPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbHead);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inregistrare";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bdDataSet bdDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private bdDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lbBackLogin;
        private System.Windows.Forms.Label lbInfo1;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.CheckBox CheckBxShowPass;
        private System.Windows.Forms.TextBox txtComPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbComPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbHead;
    }
}