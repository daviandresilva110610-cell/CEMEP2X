using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace davi_Teorema
{
    public partial class Cá : Form
    {
        public Cá()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cá_Load(object sender, EventArgs e)
        {
            StartPosition: CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c1, c2, h, c1q, c2q;
            c1 = Convert.ToDouble(txtc1.Text);
            c2 = Convert.ToDouble(txtc2.Text);

            c1q = Math.Pow(c1, 2);
            c2q = Math.Pow(c2, 2);

            h = Math.Sqrt(c1q + c2q);

            txtr.Text= Convert.ToString(Math.Round(h, 2));


        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtc1.Clear();
            txtc2.Clear();
            txtr.Clear();
            txtc1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
