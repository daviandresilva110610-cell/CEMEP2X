using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raiz_potencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtn.Clear();
            txtr.Clear();
            txtp.Clear();
            txtn.Clear();
            txtn.Focus();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, r, p;
            a = Convert.ToDouble(txtn.Text);
            r = Math.Sqrt(a);
            txtr.Text = Convert.ToString(Math.Round(r,2));

            a = Convert.ToDouble(txtn.Text);
            p = Math.Pow(a, 2);
            txtp.Text = Convert.ToString(Math.Round(p,2));
        }

        private void txtp_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartPosition:CenterToScreen();
        }
    }
}
