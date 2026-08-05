using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tipos_de_Triangulos
{
    public partial class FrmTriangulo : Form
    {
        public FrmTriangulo()
        {
            InitializeComponent();
        }

        private void FrmTriangulo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            DialogResult result;//variáveis que vai receber a informação sim ou não
            result = MessageBox.Show("Tem certeza que deseja sair?", "Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result == DialogResult)
            {
                Close();
            }

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtla.Clear();
            txtlb.Clear();
            txtlc.Clear();
            txtla.Focus();
            txteq.Visible = false;
            txtEsc.Visible = false;
            txtIso.Visible = false;
            trianguloeq.Visible = false;
            trianguloesc.Visible = false;
            trianguloiso.Visible = false;
            lblX.Visible = false;
        }

        private void btnt_Click(object sender, EventArgs e)
        {
            //declarar variáveis
            double a, b, c;
            //conversão das variáveis
            a = Convert.ToDouble(txtla.Text);
            b = Convert.ToDouble(txtlb.Text);
            c = Convert.ToDouble(txtlc.Text);

            //lógica calculo ver se é triângulo
            //operador lógico E no C# é &&
            //operador lógico OU no C# é ||
            //a<b+c
            //b<a+c
            //c<a+b
            if (a < b + c && b < a + c && c < b + a)
            {
                MessageBox.Show("Representam os lados de um triângulo", "Valores válidos", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //se for triângulo pergunte especificamente por
                //triângulo equilátero
            if(a==b && b == c)
                {
                    trianguloeq.Visible = true;
                    txteq.Visible = true;
                    lblX.Visible = false;
                    trianguloesc.Visible = false;
                    trianguloiso.Visible = false;
                    lblX.Visible = false;
                    
                }

                //triãngulo isóceles
            else if(a==b|| b==c || a == c)
                {
                    trianguloiso.Visible = true;
                    txtIso.Visible = true;
                    trianguloeq.Visible = false;
                    trianguloesc.Visible = false;
                    txteq.Visible = false;
                    txtEsc.Visible = false;
                    lblX.Visible = false;

                }

                //triângulo escaleno
            else if(a!=b && b!=c && a!=c)
                {
                    trianguloesc.Visible = true;
                    txtEsc.Visible = true;
                    trianguloeq.Visible = false;
                    trianguloiso.Visible = false;

                }
            }

            else
            {
                MessageBox.Show("Não representam os lados de um triângulo");
                trianguloeq.Visible = false;
                trianguloesc.Visible = false;
                trianguloiso.Visible = false;
                lblX.Visible = true;
            }
            //se não for triângulo
                //avise
        }
    }
}
