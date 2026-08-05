
namespace viagem
{
    partial class frmviagem
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblescolhapais = new System.Windows.Forms.Label();
            this.lstpaises = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(101, 43);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(247, 22);
            this.txtnome.TabIndex = 1;
            // 
            // lblescolhapais
            // 
            this.lblescolhapais.AutoSize = true;
            this.lblescolhapais.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblescolhapais.Location = new System.Drawing.Point(29, 86);
            this.lblescolhapais.Name = "lblescolhapais";
            this.lblescolhapais.Size = new System.Drawing.Size(141, 36);
            this.lblescolhapais.TabIndex = 2;
            this.lblescolhapais.Text = "Escolha um país:";
            // 
            // lstpaises
            // 
            this.lstpaises.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstpaises.FormattingEnabled = true;
            this.lstpaises.ItemHeight = 19;
            this.lstpaises.Items.AddRange(new object[] {
            "Alemanha",
            "Angola",
            "Brasil",
            "Coreia do Sul",
            "EUA",
            "Japão"});
            this.lstpaises.Location = new System.Drawing.Point(176, 95);
            this.lstpaises.Name = "lstpaises";
            this.lstpaises.Size = new System.Drawing.Size(110, 80);
            this.lstpaises.TabIndex = 3;
            // 
            // frmviagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 488);
            this.Controls.Add(this.lstpaises);
            this.Controls.Add(this.lblescolhapais);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmviagem";
            this.Text = "Viagens Internacionais";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblescolhapais;
        private System.Windows.Forms.ListBox lstpaises;
    }
}

