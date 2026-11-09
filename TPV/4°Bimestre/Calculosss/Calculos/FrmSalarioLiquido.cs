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
    public partial class FrmSalarioLiquido : Form
    {
        //declaração das variaveis gerais
        double salario_base, aliquota, valor_dep, bcir, inss, irrf, salario_liquido;
        int num_dep;

        private void txtSalario_Base_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalario_Base_Leave(object sender, EventArgs e)
        {
            if (salario_base < 1621.00)
            {
                txtdesconto.Text = "7,5%";
            }
            if (salario_base >= 1621.01 && salario_base <= 2836.34)
            {
                txtdesconto.Text = "9%";
            }
            if (salario_base >= 2836.35 && salario_base <= 4254.51)
            {
                txtdesconto.Text = "12%";
            }
            if (salario_base >= 4254.52 && salario_base <= 8475.55)
            {
                txtdesconto.Text = "14%";
            }
            else 
            {
                txtdesconto.Text = "R$ 977.15";
            }

        }

        private void cbonum_dep_SelectedIndexChanged(object sender, EventArgs e)
        {
            num_dep = Convert.ToInt32(cbonum_dep.Text);
            valor_dep = num_dep * 189.59;
            lblValor_Dep.Text = valor_dep.ToString("C2");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public FrmSalarioLiquido(string salario_base)
        {
            InitializeComponent();
            txtSalario_Base.Text = salario_base;
            //o valor dessa variável vai para a txtsalario_base
        }

        private void FrmSalarioLiquido_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //conversão das variáveis - Obter valores dos campos
            salario_base = Convert.ToDouble(txtSalario_Base.Text);
            num_dep = Convert.ToInt32(cbonum_dep.Text);

            //1- Calcular valor de dependentes
            valor_dep = num_dep * 189.59;
            lblValor_Dep.Text = valor_dep.ToString("C2");//C2 - aparece R$

            //2- Calcular contribuição INSS
            if (salario_base < 1621.00)
            {
                aliquota = 0.075;//7.5%
                inss = salario_base * aliquota;
                lblINSS.Text = inss.ToString("C2");
            }
            else if (salario_base >= 1621.01 && salario_base <= 2836.34)
            {
                aliquota = 0.09;
                inss = (salario_base * aliquota) - 24.32;
                lblINSS.Text = inss.ToString("C2");
            }
            else if (salario_base >= 2836.35 && salario_base <= 4254.51)
            {
                aliquota = 0.12;
                inss = (salario_base * aliquota) - 109.41;
                lblINSS.Text = inss.ToString("C2");
            }
            else if (salario_base >= 4254.52 && salario_base <= 8475.55)
            {
                aliquota = 0.12;
                inss = (salario_base * aliquota) - 194.50;
                lblINSS.Text = inss.ToString("C2");
            }
            else if (salario_base > 8475.55)
            {
                inss = 977.15;
                lblINSS.Text = inss.ToString("C2");
            }

            //3. Base de Cálculo do IRRF (BCIR)
            bcir = salario_base - inss - (num_dep * 189.59);
            label7.Text = bcir.ToString("C2");

            //4.Cálculo Inicial do IRRF
            if(bcir <= 2428.80)
            {
                lblBCIR.Text = ("Isento");
            }
            else if (bcir >= 2428.81 && bcir <= 2826.65)
            {
                irrf = ((bcir * (0.075)) - 169.44);
                lblBCIR.Text = irrf.ToString("C2");
            }
            else if (bcir >= 2826.66 && bcir <= 3751.05)
            {
                irrf = ((bcir * (0.15)) - 394.16);
                lblBCIR.Text = irrf.ToString("C2");
            }
            else if (bcir >= 3751.06 && bcir <= 4664.68)
            {
                irrf = ((bcir * (0.225)) - 675.49);
                lblBCIR.Text = irrf.ToString("C2");
            }
            else 
            {
                irrf = ((bcir * (0.275)) - 908.73);
                lblBCIR.Text = irrf.ToString("C2");
            }

            //5.Aplicação da Regra de Redução do IRRF
            salario_liquido = (salario_base - inss - irrf);
            lblSal_Liq.Text = salario_liquido.ToString("C2");
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtSalario_Base.Clear();
            txtSalario_Base.Text = "0";
            cbonum_dep.SelectedIndex = 0;
            txtdesconto.Clear();
            txtSalario_Base.Focus();
        }
    }
}
