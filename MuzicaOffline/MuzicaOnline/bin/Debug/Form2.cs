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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.bdDataSet.users);

        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtComPassword.Text == "")
            {
                MessageBox.Show("Unul dintre campuri este gol", "Inregistrare esuata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtUsername.TextLength < 6)
                {
                    lblMessage.Text = "*Alege un nume mai lung de 6 caractere";
                }
                else
                {
                    if (txtUsername.TextLength > 13)
                    {
                        lblMessage.Text = "*Numele este prea lung";
                    }
                    else
                    {
                        lblMessage.Text = "";
                        if (txtPassword.Text == txtComPassword.Text)
                        {
                            string username = txtUsername.Text;
                            string email = txtEmail.Text;
                            string pass = txtPassword.Text;
                            int valid1 = int.Parse(usersTableAdapter.validUser(username).ToString());
                            int valid2 = int.Parse(usersTableAdapter.validUser3(email).ToString());

                            if (valid1 == 0 && valid2 == 0)
                            {
                                usersTableAdapter.InsertUser(username, email, pass);
                                usersTableAdapter.Update(bdDataSet.users);
                                txtUsername.Text = "";
                                txtEmail.Text = "";
                                txtPassword.Text = "";
                                txtComPassword.Text = "";

                                MessageBox.Show("Contul tau a fost creat cu succes", "Inregistrare completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Acest cont exista deja, Va rugam sa reintroduceti", "Inregistrare esuata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtUsername.Text = "";
                                txtEmail.Text = "";
                                txtPassword.Text = "";
                                txtComPassword.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Parolele nu se potrivesc, Va rugam sa reintroduceti", "Inregistrare esuata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPassword.Text = "";
                            txtComPassword.Text = "";
                            txtPassword.Focus();
                        }
                    }
                }
            }
        }

        private void CheckBxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtComPassword.PasswordChar = '•';
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtUsername.Focus();
        }

        private void lbBackLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
