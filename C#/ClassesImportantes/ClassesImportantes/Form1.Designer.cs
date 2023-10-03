namespace ClassesImportantes
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
            this.btnMessageBox = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMessageBox
            // 
            this.btnMessageBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMessageBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessageBox.Location = new System.Drawing.Point(465, 334);
            this.btnMessageBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMessageBox.Name = "btnMessageBox";
            this.btnMessageBox.Size = new System.Drawing.Size(188, 64);
            this.btnMessageBox.TabIndex = 0;
            this.btnMessageBox.Text = "MessageBox";
            this.btnMessageBox.UseVisualStyleBackColor = true;
            this.btnMessageBox.Click += new System.EventHandler(this.btnMessageBox_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(24, 33);
            this.lbResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(602, 59);
            this.lbResultado.TabIndex = 1;
            this.lbResultado.Text = "label1";
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAleatorio.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAleatorio.Location = new System.Drawing.Point(465, 251);
            this.btnAleatorio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(188, 64);
            this.btnAleatorio.TabIndex = 2;
            this.btnAleatorio.Text = "Random";
            this.btnAleatorio.UseVisualStyleBackColor = true;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 412);
            this.Controls.Add(this.btnAleatorio);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btnMessageBox);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMessageBox;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnAleatorio;
    }
}

