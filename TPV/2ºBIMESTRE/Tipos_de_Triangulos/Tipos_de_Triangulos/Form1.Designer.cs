
namespace Tipos_de_Triangulos
{
    partial class FrmTriangulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTriangulo));
            this.txteq = new System.Windows.Forms.Label();
            this.txtEsc = new System.Windows.Forms.Label();
            this.txtIso = new System.Windows.Forms.Label();
            this.trianguloiso = new System.Windows.Forms.PictureBox();
            this.trianguloesc = new System.Windows.Forms.PictureBox();
            this.trianguloeq = new System.Windows.Forms.PictureBox();
            this.lbla = new System.Windows.Forms.Label();
            this.txtla = new System.Windows.Forms.TextBox();
            this.txtlb = new System.Windows.Forms.TextBox();
            this.txtlc = new System.Windows.Forms.TextBox();
            this.lblc = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.btnt = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.lblt = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trianguloiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trianguloesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trianguloeq)).BeginInit();
            this.SuspendLayout();
            // 
            // txteq
            // 
            this.txteq.AutoSize = true;
            this.txteq.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteq.Location = new System.Drawing.Point(428, 169);
            this.txteq.Name = "txteq";
            this.txteq.Size = new System.Drawing.Size(250, 156);
            this.txteq.TabIndex = 0;
            this.txteq.Text = resources.GetString("txteq.Text");
            this.txteq.Visible = false;
            this.txteq.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEsc
            // 
            this.txtEsc.AutoSize = true;
            this.txtEsc.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEsc.Location = new System.Drawing.Point(428, 369);
            this.txtEsc.Name = "txtEsc";
            this.txtEsc.Size = new System.Drawing.Size(196, 78);
            this.txtEsc.TabIndex = 1;
            this.txtEsc.Text = "É um polígono que não possui \r\nlados iguais, ou seja, todos os seus \r\ntrês lados " +
    "têm medidas diferentes";
            this.txtEsc.Visible = false;
            // 
            // txtIso
            // 
            this.txtIso.AutoSize = true;
            this.txtIso.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIso.Location = new System.Drawing.Point(428, 499);
            this.txtIso.Name = "txtIso";
            this.txtIso.Size = new System.Drawing.Size(237, 234);
            this.txtIso.TabIndex = 2;
            this.txtIso.Text = resources.GetString("txtIso.Text");
            this.txtIso.Visible = false;
            // 
            // trianguloiso
            // 
            this.trianguloiso.Image = global::Tipos_de_Triangulos.Properties.Resources.Imagem3;
            this.trianguloiso.Location = new System.Drawing.Point(684, 533);
            this.trianguloiso.Name = "trianguloiso";
            this.trianguloiso.Size = new System.Drawing.Size(183, 160);
            this.trianguloiso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trianguloiso.TabIndex = 5;
            this.trianguloiso.TabStop = false;
            this.trianguloiso.Visible = false;
            // 
            // trianguloesc
            // 
            this.trianguloesc.Image = global::Tipos_de_Triangulos.Properties.Resources.Imagem2;
            this.trianguloesc.Location = new System.Drawing.Point(684, 335);
            this.trianguloesc.Name = "trianguloesc";
            this.trianguloesc.Size = new System.Drawing.Size(180, 146);
            this.trianguloesc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trianguloesc.TabIndex = 4;
            this.trianguloesc.TabStop = false;
            this.trianguloesc.Visible = false;
            // 
            // trianguloeq
            // 
            this.trianguloeq.Image = global::Tipos_de_Triangulos.Properties.Resources.download;
            this.trianguloeq.Location = new System.Drawing.Point(684, 169);
            this.trianguloeq.Name = "trianguloeq";
            this.trianguloeq.Size = new System.Drawing.Size(183, 142);
            this.trianguloeq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trianguloeq.TabIndex = 3;
            this.trianguloeq.TabStop = false;
            this.trianguloeq.Visible = false;
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbla.Location = new System.Drawing.Point(38, 112);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(55, 25);
            this.lbla.TabIndex = 6;
            this.lbla.Text = "Lado A:";
            // 
            // txtla
            // 
            this.txtla.Location = new System.Drawing.Point(99, 112);
            this.txtla.Name = "txtla";
            this.txtla.Size = new System.Drawing.Size(100, 20);
            this.txtla.TabIndex = 9;
            // 
            // txtlb
            // 
            this.txtlb.Location = new System.Drawing.Point(402, 112);
            this.txtlb.Name = "txtlb";
            this.txtlb.Size = new System.Drawing.Size(100, 20);
            this.txtlb.TabIndex = 10;
            // 
            // txtlc
            // 
            this.txtlc.Location = new System.Drawing.Point(731, 112);
            this.txtlc.Name = "txtlc";
            this.txtlc.Size = new System.Drawing.Size(100, 20);
            this.txtlc.TabIndex = 11;
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc.Location = new System.Drawing.Point(670, 112);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(54, 25);
            this.lblc.TabIndex = 13;
            this.lblc.Text = "Lado C:";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb.Location = new System.Drawing.Point(341, 112);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(54, 25);
            this.lblb.TabIndex = 14;
            this.lblb.Text = "Lado B:";
            // 
            // btnt
            // 
            this.btnt.BackColor = System.Drawing.Color.GhostWhite;
            this.btnt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnt.Location = new System.Drawing.Point(66, 283);
            this.btnt.Name = "btnt";
            this.btnt.Size = new System.Drawing.Size(90, 60);
            this.btnt.TabIndex = 15;
            this.btnt.Text = "Triângulo";
            this.btnt.UseVisualStyleBackColor = false;
            this.btnt.Click += new System.EventHandler(this.btnt_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlimpar.Location = new System.Drawing.Point(66, 384);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(90, 60);
            this.btnlimpar.TabIndex = 16;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnsair.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsair.Location = new System.Drawing.Point(66, 481);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(90, 60);
            this.btnsair.TabIndex = 17;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // lblt
            // 
            this.lblt.AutoSize = true;
            this.lblt.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblt.Location = new System.Drawing.Point(320, 22);
            this.lblt.Name = "lblt";
            this.lblt.Size = new System.Drawing.Size(283, 63);
            this.lblt.TabIndex = 18;
            this.lblt.Text = "Tipos de Triângulo";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Uighur", 200.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.Color.Crimson;
            this.lblX.Location = new System.Drawing.Point(433, 263);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(383, 267);
            this.lblX.TabIndex = 19;
            this.lblX.Text = "❌";
            this.lblX.Visible = false;
            // 
            // FrmTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(911, 739);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblt);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnt);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.txtlc);
            this.Controls.Add(this.txtlb);
            this.Controls.Add(this.txtla);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.trianguloiso);
            this.Controls.Add(this.trianguloesc);
            this.Controls.Add(this.trianguloeq);
            this.Controls.Add(this.txtIso);
            this.Controls.Add(this.txtEsc);
            this.Controls.Add(this.txteq);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTriangulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Triângulos";
            this.Load += new System.EventHandler(this.FrmTriangulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trianguloiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trianguloesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trianguloeq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txteq;
        private System.Windows.Forms.Label txtEsc;
        private System.Windows.Forms.Label txtIso;
        private System.Windows.Forms.PictureBox trianguloeq;
        private System.Windows.Forms.PictureBox trianguloesc;
        private System.Windows.Forms.PictureBox trianguloiso;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.TextBox txtla;
        private System.Windows.Forms.TextBox txtlb;
        private System.Windows.Forms.TextBox txtlc;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Button btnt;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lblt;
        private System.Windows.Forms.Label lblX;
    }
}

