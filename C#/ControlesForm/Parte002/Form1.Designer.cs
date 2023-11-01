namespace Parte002
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
            this.btnExecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExecutar
            // 
            this.btnExecutar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExecutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecutar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExecutar.FlatAppearance.BorderSize = 5;
            this.btnExecutar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnExecutar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecutar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnExecutar.Location = new System.Drawing.Point(12, 363);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(238, 80);
            this.btnExecutar.TabIndex = 0;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = false;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 455);
            this.Controls.Add(this.btnExecutar);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExecutar;
    }
}

