namespace Parte039
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblCor = new System.Windows.Forms.Label();
            this.btnCores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCor
            // 
            this.lblCor.Location = new System.Drawing.Point(41, 36);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(557, 135);
            this.lblCor.TabIndex = 0;
            this.lblCor.Text = "Selecione a cor";
            this.lblCor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCores
            // 
            this.btnCores.Location = new System.Drawing.Point(270, 239);
            this.btnCores.Name = "btnCores";
            this.btnCores.Size = new System.Drawing.Size(124, 47);
            this.btnCores.TabIndex = 1;
            this.btnCores.Text = "Cores";
            this.btnCores.UseVisualStyleBackColor = true;
            this.btnCores.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 358);
            this.Controls.Add(this.btnCores);
            this.Controls.Add(this.lblCor);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Button btnCores;
    }
}

