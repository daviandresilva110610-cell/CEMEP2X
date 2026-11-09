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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Deseja sair do Sistema?",
                                    "Saída",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Exclamation);
            if (resp == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssData.Text = DateTime.Now.ToLongDateString();
            tssHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void aplicativosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acessóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?client=firefox-b-d&q=calculadora");
        }

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/?hl=pt_BR");
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel.exe");
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void salárioBrutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instaciamento do objeto form  
            frmsalariobruto salarioBruto = new frmsalariobruto();
            //chamar o form para aparecer
            salarioBruto.Show();
        }

        private void salárioLíquidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
