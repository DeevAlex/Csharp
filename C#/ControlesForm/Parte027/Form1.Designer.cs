namespace Parte027
{
    partial class Form1
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
            this.contextoInicial = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextoFinal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.contextoInicial.SuspendLayout();
            this.contextoFinal.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextoInicial
            // 
            this.contextoInicial.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.recortarToolStripMenuItem});
            this.contextoInicial.Name = "contextoInicial";
            this.contextoInicial.Size = new System.Drawing.Size(119, 48);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // recortarToolStripMenuItem
            // 
            this.recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            this.recortarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.recortarToolStripMenuItem.Text = "Recortar";
            this.recortarToolStripMenuItem.Click += new System.EventHandler(this.recortarToolStripMenuItem_Click);
            // 
            // contextoFinal
            // 
            this.contextoFinal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colarToolStripMenuItem1});
            this.contextoFinal.Name = "contextoFinal";
            this.contextoFinal.Size = new System.Drawing.Size(181, 48);
            // 
            // colarToolStripMenuItem1
            // 
            this.colarToolStripMenuItem1.Name = "colarToolStripMenuItem1";
            this.colarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.colarToolStripMenuItem1.Text = "Colar";
            this.colarToolStripMenuItem1.Click += new System.EventHandler(this.colarToolStripMenuItem1_Click);
            // 
            // txt1
            // 
            this.txt1.ContextMenuStrip = this.contextoInicial;
            this.txt1.Location = new System.Drawing.Point(103, 75);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(472, 32);
            this.txt1.TabIndex = 2;
            // 
            // txt2
            // 
            this.txt2.ContextMenuStrip = this.contextoFinal;
            this.txt2.Location = new System.Drawing.Point(103, 134);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(472, 32);
            this.txt2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 384);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.contextoInicial.ResumeLayout(false);
            this.contextoFinal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextoInicial;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recortarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextoFinal;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem1;
    }
}

