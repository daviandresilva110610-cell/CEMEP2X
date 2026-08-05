
namespace calculadora
{
    partial class lbl1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.lblresul = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnlimpa = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnsoma = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o primeiro número:\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(195, 111);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(128, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Digite o segundo número:";
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(328, 81);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(100, 20);
            this.txtn1.TabIndex = 6;
            this.txtn1.TextChanged += new System.EventHandler(this.txtn1_TextChanged);
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(328, 111);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(100, 20);
            this.txtn2.TabIndex = 7;
            // 
            // lblresul
            // 
            this.lblresul.AutoSize = true;
            this.lblresul.Location = new System.Drawing.Point(468, 88);
            this.lblresul.Name = "lblresul";
            this.lblresul.Size = new System.Drawing.Size(58, 13);
            this.lblresul.TabIndex = 8;
            this.lblresul.Text = "Resultado:";
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(338, 208);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(58, 53);
            this.btnsair.TabIndex = 9;
            this.btnsair.Text = "Sair";
            this.toolTip1.SetToolTip(this.btnsair, "sair");
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnlimpa
            // 
            this.btnlimpa.Image = global::calculadora.Properties.Resources.icon_clear32_4_fw;
            this.btnlimpa.Location = new System.Drawing.Point(338, 149);
            this.btnlimpa.Name = "btnlimpa";
            this.btnlimpa.Size = new System.Drawing.Size(58, 53);
            this.btnlimpa.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnlimpa, "limpar");
            this.btnlimpa.UseVisualStyleBackColor = true;
            this.btnlimpa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndiv
            // 
            this.btndiv.Image = global::calculadora.Properties.Resources.MISC21;
            this.btndiv.Location = new System.Drawing.Point(265, 208);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(58, 53);
            this.btndiv.TabIndex = 5;
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnmul
            // 
            this.btnmul.Image = global::calculadora.Properties.Resources.MISC20;
            this.btnmul.Location = new System.Drawing.Point(198, 208);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(58, 53);
            this.btnmul.TabIndex = 4;
            this.btnmul.UseVisualStyleBackColor = true;
            this.btnmul.Click += new System.EventHandler(this.btnmul_Click);
            // 
            // btnsub
            // 
            this.btnsub.Image = global::calculadora.Properties.Resources.MISC19;
            this.btnsub.Location = new System.Drawing.Point(265, 149);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(58, 53);
            this.btnsub.TabIndex = 3;
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnsoma
            // 
            this.btnsoma.Image = global::calculadora.Properties.Resources.MISC18;
            this.btnsoma.Location = new System.Drawing.Point(198, 149);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(55, 53);
            this.btnsoma.TabIndex = 2;
            this.btnsoma.UseVisualStyleBackColor = true;
            this.btnsoma.Click += new System.EventHandler(this.btnsoma_Click);
            // 
            // lbl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::calculadora.Properties.Resources._8478265579_95acf1944c_c_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btnlimpa);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.lblresul);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnsoma);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "lbl1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnsoma;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.Label lblresul;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnlimpa;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

