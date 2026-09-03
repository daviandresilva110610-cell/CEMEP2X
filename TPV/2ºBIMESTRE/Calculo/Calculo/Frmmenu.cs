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
    public partial class Frmmenu : Form
    {
        public Frmmenu()
        {
            InitializeComponent();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Deseja sair do Sistema?","Saída",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);

            if(resp == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssData.Text = DateTime.Now.ToLongDateString();
            tssHora.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
