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
    public partial class frmsalariobruto : Form
    {
        //local das deckarações gerais
        double horas, valorHora, SalarioBruto;

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox2.Text, out double horas))
            {
                MessageBox.Show("Campo deve estar preenchido");
                textBox2.Focus();
            }
            else if (horas < 120 || horas > 220)
            {
                MessageBox.Show("Campo deve estar entre 120 e 220 horas");
                textBox2.Clear();
                textBox2.Focus();

            }
        }

        public frmsalariobruto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void lblsal_Click(object sender, EventArgs e)
        {

        }

        private void btnprox_Click(object sender, EventArgs e)
        {
            // instanciamento levando o valor do salario bruto para outro form no campo salario base
            FrmSalarioLiquido salarioLiquido = new FrmSalarioLiquido(lblsal.Text);
            salarioLiquido.Show();
        }

        private void frmsalariobruto_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Lê os valores digitados nas caixas de texto
                horas = Convert.ToDouble(textBox2.Text);
                valorHora = Convert.ToDouble(textBox3.Text);

                //Calcula o salário bruto
                SalarioBruto = horas * valorHora;

                //Exibe o resultado formatado como moeda (R$)
                lblsal.Text = SalarioBruto.ToString();
            }
            catch
            {
                MessageBox.Show("Por favor, digite apenas números válidos.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}