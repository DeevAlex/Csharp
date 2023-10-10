namespace Formulario
{
    partial class FormMain
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
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.btnSegunda = new System.Windows.Forms.Button();
            this.btnSegundaThread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.Location = new System.Drawing.Point(12, 38);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(757, 151);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "Principal";
            this.lblPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSegunda
            // 
            this.btnSegunda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSegunda.Location = new System.Drawing.Point(16, 378);
            this.btnSegunda.Name = "btnSegunda";
            this.btnSegunda.Size = new System.Drawing.Size(169, 59);
            this.btnSegunda.TabIndex = 1;
            this.btnSegunda.Text = "Segunda Form";
            this.btnSegunda.UseVisualStyleBackColor = true;
            this.btnSegunda.Click += new System.EventHandler(this.btnSegunda_Click);
            // 
            // btnSegundaThread
            // 
            this.btnSegundaThread.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSegundaThread.Location = new System.Drawing.Point(191, 378);
            this.btnSegundaThread.Name = "btnSegundaThread";
            this.btnSegundaThread.Size = new System.Drawing.Size(238, 59);
            this.btnSegundaThread.TabIndex = 2;
            this.btnSegundaThread.Text = "Segunda Form Thread";
            this.btnSegundaThread.UseVisualStyleBackColor = true;
            this.btnSegundaThread.Click += new System.EventHandler(this.btnSegundaThread_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 449);
            this.Controls.Add(this.btnSegundaThread);
            this.Controls.Add(this.btnSegunda);
            this.Controls.Add(this.lblPrincipal);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Button btnSegunda;
        private System.Windows.Forms.Button btnSegundaThread;
    }
}

