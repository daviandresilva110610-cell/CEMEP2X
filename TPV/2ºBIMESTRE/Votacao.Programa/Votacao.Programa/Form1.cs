using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Votacao.Programa
{
    public partial class frmeleicao : Form
    {
        int voto;
        int ednaldo = 0, Manoel = 0, Feijfarinha = 0;
        int nulos = 0, brancos = 0, total_votos = 0;

        private void btnfjfarinha_Click(object sender, EventArgs e)
        {
            Feijfarinha = Feijfarinha + 1;
        }

        private void btnbranco_Click(object sender, EventArgs e)
        {
            brancos = brancos = 1;
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnencerrar_Click(object sender, EventArgs e)
        {
            btnencerrar.Hide();
            btnbranco.Hide();
            btnednaldo.Hide();
            btnfjfarinha.Hide();
            btnmanoel.Hide();
            btnconfiramr.Hide();
            btnnulo.Hide();

            lblvtbranco.Text = brancos.ToString();
            lblvtednaldo.Text = ednaldo.ToString();
            lblvtfeij.Text = Feijfarinha.ToString();
            lblvtmanoel.Text = Manoel.ToString();
            lblvtnulo.Text = nulos.ToString();

            lblnumbranco.Show();
            lblnumednaldo.Show();
            lblnumfeij.Show();
            lblnummanoel.Show();
            lblnumnulo.Show();
            lblvtbranco.Show();
            lblvtednaldo.Show();
            lblvtfeij.Show();
            lblvtmanoel.Show();
            lblvtnulo.Show();
        }

        private void btnmanoel_Click(object sender, EventArgs e)
        {
            Manoel = Manoel + 1;
        }

        private void btnednaldo_Click(object sender, EventArgs e)
        {
            ednaldo = ednaldo + 1;
        }

        public frmeleicao()
        {
            InitializeComponent();
        }

        private void btnnulo_Click(object sender, EventArgs e)
        {
            nulos = nulos + 1;
        }
    }
}
