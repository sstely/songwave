using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MuzicaOnline
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.bdDataSet.users);
            
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;
            int valid = int.Parse(usersTableAdapter.validUser2(user, pass).ToString());

            if (valid != 0)
            {
                this.Hide();
                usersTableAdapter.userInfo(bdDataSet.users, user);
                DataTable t = bdDataSet.users;
                string username = t.Rows[0]["username"].ToString();
                frmBase Baza = new frmBase(username);
                Baza.FormClosed += new FormClosedEventHandler(Baza_FormClosed);
                Baza.ShowDialog();

            }
            else
            {
                MessageBox.Show("Datele introduse sunt invalide, Va rugam incercati din nou", "Logare esuata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }

        void Baza_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void CheckBxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister Register = new frmRegister();
            Register.FormClosed += new FormClosedEventHandler(Register_FormClosed);
            Register.ShowDialog();
        }

        void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
