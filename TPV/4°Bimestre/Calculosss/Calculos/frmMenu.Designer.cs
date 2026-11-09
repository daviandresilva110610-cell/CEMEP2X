
namespace Calculos
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicativosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salárioBrutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salárioLíquidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impostoDeRendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acessóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.aplicativosToolStripMenuItem,
            this.acessóriosToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.Image = global::Calculos.Properties.Resources.DISK04;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // aplicativosToolStripMenuItem
            // 
            this.aplicativosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salárioBrutoToolStripMenuItem,
            this.salárioLíquidoToolStripMenuItem,
            this.impostoDeRendaToolStripMenuItem});
            this.aplicativosToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aplicativosToolStripMenuItem.Name = "aplicativosToolStripMenuItem";
            this.aplicativosToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.aplicativosToolStripMenuItem.Text = "Aplicativos";
            this.aplicativosToolStripMenuItem.Click += new System.EventHandler(this.aplicativosToolStripMenuItem_Click);
            // 
            // salárioBrutoToolStripMenuItem
            // 
            this.salárioBrutoToolStripMenuItem.Name = "salárioBrutoToolStripMenuItem";
            this.salárioBrutoToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.salárioBrutoToolStripMenuItem.Text = "Salário Bruto";
            this.salárioBrutoToolStripMenuItem.Click += new System.EventHandler(this.salárioBrutoToolStripMenuItem_Click);
            // 
            // salárioLíquidoToolStripMenuItem
            // 
            this.salárioLíquidoToolStripMenuItem.Name = "salárioLíquidoToolStripMenuItem";
            this.salárioLíquidoToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.salárioLíquidoToolStripMenuItem.Text = "Salário Líquido";
            this.salárioLíquidoToolStripMenuItem.Click += new System.EventHandler(this.salárioLíquidoToolStripMenuItem_Click);
            // 
            // impostoDeRendaToolStripMenuItem
            // 
            this.impostoDeRendaToolStripMenuItem.Name = "impostoDeRendaToolStripMenuItem";
            this.impostoDeRendaToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.impostoDeRendaToolStripMenuItem.Text = "Imposto de Renda";
            // 
            // acessóriosToolStripMenuItem
            // 
            this.acessóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.googleToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.excelToolStripMenuItem,
            this.notepadToolStripMenuItem});
            this.acessóriosToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acessóriosToolStripMenuItem.Name = "acessóriosToolStripMenuItem";
            this.acessóriosToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.acessóriosToolStripMenuItem.Text = "Acessórios";
            this.acessóriosToolStripMenuItem.Click += new System.EventHandler(this.acessóriosToolStripMenuItem_Click);
            // 
            // googleToolStripMenuItem
            // 
            this.googleToolStripMenuItem.Name = "googleToolStripMenuItem";
            this.googleToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.googleToolStripMenuItem.Text = "Google";
            this.googleToolStripMenuItem.Click += new System.EventHandler(this.googleToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.notepadToolStripMenuItem.Text = "Notepad";
            this.notepadToolStripMenuItem.Click += new System.EventHandler(this.notepadToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.programadorToolStripMenuItem});
            this.sobreToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // programadorToolStripMenuItem
            // 
            this.programadorToolStripMenuItem.Name = "programadorToolStripMenuItem";
            this.programadorToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.programadorToolStripMenuItem.Text = "Programador";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Calculos.Properties.Resources.TRFFC19A;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Sair";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssData,
            this.tssHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(113, 17);
            this.toolStripStatusLabel1.Text = "Luigi Michilin";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // tssData
            // 
            this.tssData.Font = new System.Drawing.Font("Mongolian Baiti", 10F);
            this.tssData.Name = "tssData";
            this.tssData.Size = new System.Drawing.Size(33, 17);
            this.tssData.Text = "Data";
            // 
            // tssHora
            // 
            this.tssHora.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssHora.Name = "tssHora";
            this.tssHora.Size = new System.Drawing.Size(33, 17);
            this.tssHora.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Calculos.Properties.Resources.canvas;
            this.pictureBox2.Location = new System.Drawing.Point(596, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu Principal - Projeto Cálculo";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicativosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salárioBrutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salárioLíquidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impostoDeRendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acessóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programadorToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssData;
        private System.Windows.Forms.ToolStripStatusLabel tssHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}