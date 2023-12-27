namespace TrasferirArquivosServer
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
            this.btnPararServidor = new System.Windows.Forms.Button();
            this.btnEstabelecerConexao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnderecoIP = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.NumericUpDown();
            this.txtPasta = new System.Windows.Forms.LinkLabel();
            this.listaLogs = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPararServidor
            // 
            this.btnPararServidor.Location = new System.Drawing.Point(276, 169);
            this.btnPararServidor.Name = "btnPararServidor";
            this.btnPararServidor.Size = new System.Drawing.Size(258, 54);
            this.btnPararServidor.TabIndex = 0;
            this.btnPararServidor.Text = "Parar Servidor";
            this.btnPararServidor.UseVisualStyleBackColor = true;
            this.btnPararServidor.Click += new System.EventHandler(this.btnPararServidor_Click);
            // 
            // btnEstabelecerConexao
            // 
            this.btnEstabelecerConexao.Location = new System.Drawing.Point(12, 169);
            this.btnEstabelecerConexao.Name = "btnEstabelecerConexao";
            this.btnEstabelecerConexao.Size = new System.Drawing.Size(258, 54);
            this.btnEstabelecerConexao.TabIndex = 1;
            this.btnEstabelecerConexao.Text = "Estabelecer Conexão";
            this.btnEstabelecerConexao.UseVisualStyleBackColor = true;
            this.btnEstabelecerConexao.Click += new System.EventHandler(this.btnEstabelecerConexao_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Servidor para Compartilhar Arquivos";
            // 
            // txtEnderecoIP
            // 
            this.txtEnderecoIP.Location = new System.Drawing.Point(12, 131);
            this.txtEnderecoIP.Name = "txtEnderecoIP";
            this.txtEnderecoIP.Size = new System.Drawing.Size(258, 32);
            this.txtEnderecoIP.TabIndex = 3;
            this.txtEnderecoIP.Text = "127.0.0.1";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(276, 132);
            this.txtPorta.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtPorta.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(85, 32);
            this.txtPorta.TabIndex = 4;
            this.txtPorta.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txtPasta
            // 
            this.txtPasta.AutoSize = true;
            this.txtPasta.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.txtPasta.Location = new System.Drawing.Point(12, 236);
            this.txtPasta.Name = "txtPasta";
            this.txtPasta.Size = new System.Drawing.Size(295, 24);
            this.txtPasta.TabIndex = 5;
            this.txtPasta.TabStop = true;
            this.txtPasta.Text = "Clique para selecionar a pasta";
            this.txtPasta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtPasta_LinkClicked);
            // 
            // listaLogs
            // 
            this.listaLogs.BackColor = System.Drawing.SystemColors.Info;
            this.listaLogs.FormattingEnabled = true;
            this.listaLogs.ItemHeight = 24;
            this.listaLogs.Location = new System.Drawing.Point(16, 277);
            this.listaLogs.Name = "listaLogs";
            this.listaLogs.Size = new System.Drawing.Size(557, 124);
            this.listaLogs.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 414);
            this.Controls.Add(this.listaLogs);
            this.Controls.Add(this.txtPasta);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.txtEnderecoIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEstabelecerConexao);
            this.Controls.Add(this.btnPararServidor);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPorta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPararServidor;
        private System.Windows.Forms.Button btnEstabelecerConexao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnderecoIP;
        private System.Windows.Forms.NumericUpDown txtPorta;
        private System.Windows.Forms.LinkLabel txtPasta;
        private System.Windows.Forms.ListBox listaLogs;
    }
}

