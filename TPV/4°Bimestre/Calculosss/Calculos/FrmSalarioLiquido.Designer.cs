
namespace Calculos
{
    partial class FrmSalarioLiquido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalarioLiquido));
            this.txtSalario_Base = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblsb = new System.Windows.Forms.Label();
            this.slb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdesconto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbonum_dep = new System.Windows.Forms.ComboBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSal_Liq = new System.Windows.Forms.Label();
            this.lblValor_Dep = new System.Windows.Forms.Label();
            this.lblINSS = new System.Windows.Forms.Label();
            this.lblBCIR = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSalario_Base
            // 
            this.txtSalario_Base.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario_Base.Location = new System.Drawing.Point(315, 69);
            this.txtSalario_Base.Name = "txtSalario_Base";
            this.txtSalario_Base.Size = new System.Drawing.Size(273, 26);
            this.txtSalario_Base.TabIndex = 10;
            this.txtSalario_Base.TextChanged += new System.EventHandler(this.txtSalario_Base_TextChanged);
            this.txtSalario_Base.Leave += new System.EventHandler(this.txtSalario_Base_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Calculos.Properties.Resources.canvas;
            this.pictureBox2.Location = new System.Drawing.Point(609, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // lblsb
            // 
            this.lblsb.AutoSize = true;
            this.lblsb.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblsb.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsb.ForeColor = System.Drawing.Color.White;
            this.lblsb.Location = new System.Drawing.Point(213, 9);
            this.lblsb.Name = "lblsb";
            this.lblsb.Size = new System.Drawing.Size(354, 29);
            this.lblsb.TabIndex = 12;
            this.lblsb.Text = "Calculadora Salário Líquido";
            // 
            // slb
            // 
            this.slb.AutoSize = true;
            this.slb.BackColor = System.Drawing.Color.MidnightBlue;
            this.slb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slb.ForeColor = System.Drawing.Color.White;
            this.slb.Location = new System.Drawing.Point(36, 72);
            this.slb.Name = "slb";
            this.slb.Size = new System.Drawing.Size(154, 20);
            this.slb.TabIndex = 13;
            this.slb.Text = "Salário base (R$):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Número de dependentes";
            // 
            // txtdesconto
            // 
            this.txtdesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesconto.Location = new System.Drawing.Point(315, 150);
            this.txtdesconto.Name = "txtdesconto";
            this.txtdesconto.Size = new System.Drawing.Size(273, 26);
            this.txtdesconto.TabIndex = 14;
            this.txtdesconto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Desconto em porcentagem (%):";
            // 
            // cbonum_dep
            // 
            this.cbonum_dep.FormattingEnabled = true;
            this.cbonum_dep.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbonum_dep.Location = new System.Drawing.Point(315, 114);
            this.cbonum_dep.Name = "cbonum_dep";
            this.cbonum_dep.Size = new System.Drawing.Size(273, 21);
            this.cbonum_dep.TabIndex = 17;
            this.cbonum_dep.SelectedIndexChanged += new System.EventHandler(this.cbonum_dep_SelectedIndexChanged);
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.MidnightBlue;
            this.btncalcular.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.ForeColor = System.Drawing.Color.White;
            this.btncalcular.Location = new System.Drawing.Point(12, 196);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(776, 40);
            this.btncalcular.TabIndex = 18;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Desconto de IRRF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MidnightBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Contribuição INSS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MidnightBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "N° de Dependentes X R$ 189,59:";
            // 
            // lblSal_Liq
            // 
            this.lblSal_Liq.AutoSize = true;
            this.lblSal_Liq.BackColor = System.Drawing.Color.Lime;
            this.lblSal_Liq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSal_Liq.ForeColor = System.Drawing.Color.White;
            this.lblSal_Liq.Location = new System.Drawing.Point(78, 381);
            this.lblSal_Liq.Name = "lblSal_Liq";
            this.lblSal_Liq.Size = new System.Drawing.Size(177, 25);
            this.lblSal_Liq.TabIndex = 22;
            this.lblSal_Liq.Text = "Salário Líquido:";
            // 
            // lblValor_Dep
            // 
            this.lblValor_Dep.AutoSize = true;
            this.lblValor_Dep.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblValor_Dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor_Dep.ForeColor = System.Drawing.Color.White;
            this.lblValor_Dep.Location = new System.Drawing.Point(317, 257);
            this.lblValor_Dep.Name = "lblValor_Dep";
            this.lblValor_Dep.Size = new System.Drawing.Size(51, 20);
            this.lblValor_Dep.TabIndex = 23;
            this.lblValor_Dep.Text = "Valor";
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINSS.ForeColor = System.Drawing.Color.White;
            this.lblINSS.Location = new System.Drawing.Point(317, 297);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(51, 20);
            this.lblINSS.TabIndex = 24;
            this.lblINSS.Text = "Valor";
            // 
            // lblBCIR
            // 
            this.lblBCIR.AutoSize = true;
            this.lblBCIR.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblBCIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBCIR.ForeColor = System.Drawing.Color.White;
            this.lblBCIR.Location = new System.Drawing.Point(317, 338);
            this.lblBCIR.Name = "lblBCIR";
            this.lblBCIR.Size = new System.Drawing.Size(51, 20);
            this.lblBCIR.TabIndex = 25;
            this.lblBCIR.Text = "Valor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.MidnightBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(463, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Valor BCIR:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(573, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Valor";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(633, 381);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(144, 40);
            this.btnSair.TabIndex = 30;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.Gray;
            this.btnlimpar.ForeColor = System.Drawing.Color.White;
            this.btnlimpar.Location = new System.Drawing.Point(633, 335);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(144, 40);
            this.btnlimpar.TabIndex = 29;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // FrmSalarioLiquido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblBCIR);
            this.Controls.Add(this.lblINSS);
            this.Controls.Add(this.lblValor_Dep);
            this.Controls.Add(this.lblSal_Liq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.cbonum_dep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdesconto);
            this.Controls.Add(this.slb);
            this.Controls.Add(this.lblsb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtSalario_Base);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSalarioLiquido";
            this.Text = "FrmSalarioLiquido";
            this.Load += new System.EventHandler(this.FrmSalarioLiquido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalario_Base;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblsb;
        private System.Windows.Forms.Label slb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdesconto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbonum_dep;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblValor_Dep;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label lblBCIR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSal_Liq;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnlimpar;
    }
}