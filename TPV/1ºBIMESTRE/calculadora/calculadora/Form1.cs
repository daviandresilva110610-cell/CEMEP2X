using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class lbl1 : Form
    {
        int N1, N2, R;

        public lbl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtn1.Clear();
            txtn2.Clear();
            txtn1.Focus();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            
            //Converção das variaveis
            N1 = Convert.ToInt32(txtn1.Text);
            N2 = Convert.ToInt32(txtn2.Text);
            //Processamento/calculo
            R = N1 + N2;
            // Converção para string
            lblresul.Text = Convert.ToString(R);

        }

        private void txtn1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            
            N1 = Convert.ToInt32(txtn1.Text);
            N2 = Convert.ToInt32(txtn2.Text);
            R = N1 - N2;
            lblresul.Text = Convert.ToString(R);

        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            
            N1 = Convert.ToInt32(txtn1.Text);
            N2 = Convert.ToInt32(txtn2.Text);
            R = N1 * N2;
            lblresul.Text = Convert.ToString(R);

        }

        private void btndiv_Click(object sender, EventArgs e)
        {
           
            N1 = Convert.ToInt32(txtn1.Text);
            N2 = Convert.ToInt32(txtn2.Text);
            R = N1/N2;
            lblresul.Text = Convert.ToString(R);
        }
    }
}
