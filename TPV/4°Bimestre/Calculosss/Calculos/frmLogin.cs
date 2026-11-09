using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculos
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "luigi" && txtSenha.Text == "123")
            {
                MessageBox.Show("Bem-vindo ao sistema...");
                //instanciamento
                frmMenu menu = new frmMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Username ou senha incorreto. Por favor tente novamente!");
                txtUser.Clear();
                txtSenha.Clear();
                txtUser.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //para fechar uma aplicação com vários forms:
            Application.Exit();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
