namespace Parte015
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
            this.progress = new System.Windows.Forms.ProgressBar();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(12, 81);
            this.progress.MarqueeAnimationSpeed = 200;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(750, 23);
            this.progress.Step = 1;
            this.progress.TabIndex = 0;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecutar.Location = new System.Drawing.Point(12, 355);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(115, 54);
            this.btnExecutar.TabIndex = 1;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 421);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.progress);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button btnExecutar;
    }
}

