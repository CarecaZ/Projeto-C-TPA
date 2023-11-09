
namespace exerclooping
{
    partial class frmprincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.paraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enquantoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.repitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.áreaTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabuadaToolStripMenuItem,
            this.cFToolStripMenuItem,
            this.áreaTotalToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programasToolStripMenuItem.Text = "Programas";
            this.programasToolStripMenuItem.Click += new System.EventHandler(this.programasToolStripMenuItem_Click_1);
            // 
            // tabuadaToolStripMenuItem
            // 
            this.tabuadaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.paraToolStripMenuItem,
            this.entToolStripMenuItem});
            this.tabuadaToolStripMenuItem.Name = "tabuadaToolStripMenuItem";
            this.tabuadaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tabuadaToolStripMenuItem.Text = "Tabuada";
            this.tabuadaToolStripMenuItem.Click += new System.EventHandler(this.tabuadaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.toolStripMenuItem2.Text = "Enquanto";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // paraToolStripMenuItem
            // 
            this.paraToolStripMenuItem.Name = "paraToolStripMenuItem";
            this.paraToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.paraToolStripMenuItem.Text = "Para";
            this.paraToolStripMenuItem.Click += new System.EventHandler(this.paraToolStripMenuItem_Click);
            // 
            // entToolStripMenuItem
            // 
            this.entToolStripMenuItem.Name = "entToolStripMenuItem";
            this.entToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.entToolStripMenuItem.Text = "Repita";
            this.entToolStripMenuItem.Click += new System.EventHandler(this.entToolStripMenuItem_Click);
            // 
            // cFToolStripMenuItem
            // 
            this.cFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enquantoToolStripMenuItem,
            this.paraToolStripMenuItem1,
            this.repitaToolStripMenuItem});
            this.cFToolStripMenuItem.Name = "cFToolStripMenuItem";
            this.cFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cFToolStripMenuItem.Text = "°C = °F";
            // 
            // enquantoToolStripMenuItem
            // 
            this.enquantoToolStripMenuItem.Name = "enquantoToolStripMenuItem";
            this.enquantoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enquantoToolStripMenuItem.Text = "Enquanto";
            this.enquantoToolStripMenuItem.Click += new System.EventHandler(this.enquantoToolStripMenuItem_Click);
            // 
            // paraToolStripMenuItem1
            // 
            this.paraToolStripMenuItem1.Name = "paraToolStripMenuItem1";
            this.paraToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.paraToolStripMenuItem1.Text = "Para";
            this.paraToolStripMenuItem1.Click += new System.EventHandler(this.paraToolStripMenuItem1_Click);
            // 
            // repitaToolStripMenuItem
            // 
            this.repitaToolStripMenuItem.Name = "repitaToolStripMenuItem";
            this.repitaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.repitaToolStripMenuItem.Text = "Repita";
            this.repitaToolStripMenuItem.Click += new System.EventHandler(this.repitaToolStripMenuItem_Click);
            // 
            // áreaTotalToolStripMenuItem
            // 
            this.áreaTotalToolStripMenuItem.Name = "áreaTotalToolStripMenuItem";
            this.áreaTotalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.áreaTotalToolStripMenuItem.Text = "Área Total";
            this.áreaTotalToolStripMenuItem.Click += new System.EventHandler(this.áreaTotalToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::exerclooping.Properties.Resources.vino;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frmprincipal_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabuadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem paraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enquantoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem repitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem áreaTotalToolStripMenuItem;
    }
}

