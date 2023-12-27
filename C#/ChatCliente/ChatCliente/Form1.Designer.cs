namespace ChatCliente
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
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtServidorIP = new System.Windows.Forms.TextBox();
            this.numPortaHost = new System.Windows.Forms.NumericUpDown();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPortaHost)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(406, 57);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(120, 32);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(13, 57);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(387, 32);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "Visitante";
            // 
            // txtServidorIP
            // 
            this.txtServidorIP.Location = new System.Drawing.Point(12, 13);
            this.txtServidorIP.Name = "txtServidorIP";
            this.txtServidorIP.Size = new System.Drawing.Size(388, 32);
            this.txtServidorIP.TabIndex = 3;
            this.txtServidorIP.Text = "127.0.0.1";
            // 
            // numPortaHost
            // 
            this.numPortaHost.Location = new System.Drawing.Point(406, 13);
            this.numPortaHost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numPortaHost.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPortaHost.Name = "numPortaHost";
            this.numPortaHost.Size = new System.Drawing.Size(120, 32);
            this.numPortaHost.TabIndex = 4;
            this.numPortaHost.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(14, 570);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(387, 32);
            this.txtMensagem.TabIndex = 5;
            this.txtMensagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMensagem_KeyPress);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(407, 570);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(119, 32);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.Location = new System.Drawing.Point(14, 605);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(512, 73);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Não conectado";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(14, 96);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(512, 468);
            this.txtLog.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 687);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.numPortaHost);
            this.Controls.Add(this.txtServidorIP);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnConectar);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPortaHost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtServidorIP;
        private System.Windows.Forms.NumericUpDown numPortaHost;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox txtLog;
    }
}

