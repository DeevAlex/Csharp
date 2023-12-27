namespace ChatServer
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
            this.txtIP = new System.Windows.Forms.TextBox();
            this.numPorta = new System.Windows.Forms.NumericUpDown();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.listaLogs = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPorta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(13, 13);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(215, 32);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "127.0.0.1";
            // 
            // numPorta
            // 
            this.numPorta.Location = new System.Drawing.Point(235, 13);
            this.numPorta.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numPorta.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPorta.Name = "numPorta";
            this.numPorta.Size = new System.Drawing.Size(74, 32);
            this.numPorta.TabIndex = 1;
            this.numPorta.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(315, 12);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(272, 33);
            this.btnStartServer.TabIndex = 2;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // listaLogs
            // 
            this.listaLogs.FormattingEnabled = true;
            this.listaLogs.ItemHeight = 24;
            this.listaLogs.Location = new System.Drawing.Point(13, 52);
            this.listaLogs.Name = "listaLogs";
            this.listaLogs.Size = new System.Drawing.Size(574, 268);
            this.listaLogs.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 337);
            this.Controls.Add(this.listaLogs);
            this.Controls.Add(this.btnStartServer);
            this.Controls.Add(this.numPorta);
            this.Controls.Add(this.txtIP);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPorta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.NumericUpDown numPorta;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.ListBox listaLogs;
    }
}

