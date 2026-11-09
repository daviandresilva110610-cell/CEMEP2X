
namespace Calculos
{
    partial class frmsalariobruto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsalariobruto));
            this.lblsb = new System.Windows.Forms.Label();
            this.lblnf = new System.Windows.Forms.Label();
            this.lblhtm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnprox = new System.Windows.Forms.Button();
            this.lblsal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblsb
            // 
            this.lblsb.AutoSize = true;
            this.lblsb.BackColor = System.Drawing.Color.Gold;
            this.lblsb.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsb.ForeColor = System.Drawing.Color.White;
            this.lblsb.Location = new System.Drawing.Point(238, 9);
            this.lblsb.Name = "lblsb";
            this.lblsb.Size = new System.Drawing.Size(326, 29);
            this.lblsb.TabIndex = 5;
            this.lblsb.Text = "Calculadora Salário Bruto";
            // 
            // lblnf
            // 
            this.lblnf.AutoSize = true;
            this.lblnf.BackColor = System.Drawing.Color.Gold;
            this.lblnf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnf.ForeColor = System.Drawing.Color.White;
            this.lblnf.Location = new System.Drawing.Point(25, 106);
            this.lblnf.Name = "lblnf";
            this.lblnf.Size = new System.Drawing.Size(184, 20);
            this.lblnf.TabIndex = 6;
            this.lblnf.Text = "Nome do Funcionário:";
            this.lblnf.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblhtm
            // 
            this.lblhtm.AutoSize = true;
            this.lblhtm.BackColor = System.Drawing.Color.Gold;
            this.lblhtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhtm.ForeColor = System.Drawing.Color.White;
            this.lblhtm.Location = new System.Drawing.Point(25, 147);
            this.lblhtm.Name = "lblhtm";
            this.lblhtm.Size = new System.Drawing.Size(229, 20);
            this.lblhtm.TabIndex = 7;
            this.lblhtm.Text = "Horas Trabalhadas no Mês:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor da Hora Trabalhada:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(219, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(372, 26);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(260, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(81, 26);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(260, 185);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(81, 26);
            this.textBox3.TabIndex = 11;
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.Gold;
            this.btncalcular.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.ForeColor = System.Drawing.Color.White;
            this.btncalcular.Location = new System.Drawing.Point(12, 235);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(776, 40);
            this.btncalcular.TabIndex = 12;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.Gray;
            this.btnlimpar.ForeColor = System.Drawing.Color.White;
            this.btnlimpar.Location = new System.Drawing.Point(648, 296);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(140, 40);
            this.btnlimpar.TabIndex = 13;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnprox
            // 
            this.btnprox.BackColor = System.Drawing.Color.Plum;
            this.btnprox.ForeColor = System.Drawing.Color.Green;
            this.btnprox.Location = new System.Drawing.Point(648, 359);
            this.btnprox.Name = "btnprox";
            this.btnprox.Size = new System.Drawing.Size(140, 40);
            this.btnprox.TabIndex = 14;
            this.btnprox.Text = "Próximo -->";
            this.btnprox.UseVisualStyleBackColor = false;
            this.btnprox.Click += new System.EventHandler(this.btnprox_Click);
            // 
            // lblsal
            // 
            this.lblsal.AutoSize = true;
            this.lblsal.BackColor = System.Drawing.Color.Plum;
            this.lblsal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsal.ForeColor = System.Drawing.Color.White;
            this.lblsal.Location = new System.Drawing.Point(144, 316);
            this.lblsal.Name = "lblsal";
            this.lblsal.Size = new System.Drawing.Size(198, 25);
            this.lblsal.TabIndex = 15;
            this.lblsal.Text = "Salário Calculado";
            this.lblsal.Click += new System.EventHandler(this.lblsal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(106, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "R$";
            // 
            // frmsalariobruto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblsal);
            this.Controls.Add(this.btnprox);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblhtm);
            this.Controls.Add(this.lblnf);
            this.Controls.Add(this.lblsb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmsalariobruto";
            this.Text = "frmsalariobruto";
            this.Load += new System.EventHandler(this.frmsalariobruto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblsb;
        private System.Windows.Forms.Label lblnf;
        private System.Windows.Forms.Label lblhtm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnprox;
        private System.Windows.Forms.Label lblsal;
        private System.Windows.Forms.Label label1;
    }
}