namespace Parte007
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
            this.combo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combo
            // 
            this.combo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo.Dock = System.Windows.Forms.DockStyle.Top;
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(0, 0);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(703, 32);
            this.combo.TabIndex = 0;
            this.combo.Text = "Selecione um Item";
            this.combo.SelectedIndexChanged += new System.EventHandler(this.combo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(477, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 72);
            this.button1.TabIndex = 1;
            this.button1.Text = "Executa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 378);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.combo);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.Button button1;
    }
}

