namespace TransferirArquivoCliente
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
            this.btnEnviarArquivo = new System.Windows.Forms.Button();
            this.txtEnderecoIP = new System.Windows.Forms.TextBox();
            this.txtPortaHost = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArquivo = new System.Windows.Forms.LinkLabel();
            this.labelStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtPortaHost)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnviarArquivo
            // 
            this.btnEnviarArquivo.Location = new System.Drawing.Point(29, 202);
            this.btnEnviarArquivo.Name = "btnEnviarArquivo";
            this.btnEnviarArquivo.Size = new System.Drawing.Size(341, 55);
            this.btnEnviarArquivo.TabIndex = 0;
            this.btnEnviarArquivo.Text = "Enviar Arquivo";
            this.btnEnviarArquivo.UseVisualStyleBackColor = true;
            this.btnEnviarArquivo.Click += new System.EventHandler(this.btnEnviarArquivo_Click);
            // 
            // txtEnderecoIP
            // 
            this.txtEnderecoIP.Location = new System.Drawing.Point(29, 110);
            this.txtEnderecoIP.Name = "txtEnderecoIP";
            this.txtEnderecoIP.Size = new System.Drawing.Size(255, 32);
            this.txtEnderecoIP.TabIndex = 1;
            this.txtEnderecoIP.Text = "127.0.0.1";
            // 
            // txtPortaHost
            // 
            this.txtPortaHost.Location = new System.Drawing.Point(290, 111);
            this.txtPortaHost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtPortaHost.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtPortaHost.Name = "txtPortaHost";
            this.txtPortaHost.Size = new System.Drawing.Size(80, 32);
            this.txtPortaHost.TabIndex = 2;
            this.txtPortaHost.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cliente para Compartilhar Arquivos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtArquivo
            // 
            this.txtArquivo.AutoSize = true;
            this.txtArquivo.Location = new System.Drawing.Point(25, 159);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(345, 24);
            this.txtArquivo.TabIndex = 4;
            this.txtArquivo.TabStop = true;
            this.txtArquivo.Text = "Clique para selecionar um arquivo...";
            this.txtArquivo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtArquivo_LinkClicked);
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.SystemColors.Control;
            this.labelStatus.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.Green;
            this.labelStatus.Location = new System.Drawing.Point(63, 300);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(618, 56);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Status";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 394);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPortaHost);
            this.Controls.Add(this.txtEnderecoIP);
            this.Controls.Add(this.btnEnviarArquivo);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtPortaHost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviarArquivo;
        private System.Windows.Forms.TextBox txtEnderecoIP;
        private System.Windows.Forms.NumericUpDown txtPortaHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel txtArquivo;
        private System.Windows.Forms.Label labelStatus;
    }
}

