using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void checkboxseepass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkboxseepass.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtusername.Text == "Davi" && txtpassword.Text == "123")
            {
                MessageBox.Show("Bem-vindo ao Sistema...");
                Frmmenu menu = new Frmmenu();
                menu.Show();
                FrmLogin login = new FrmLogin();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tente novamente");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
