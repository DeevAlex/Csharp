namespace Parte003
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(79, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(420, 32);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "DIGITE ALGO!";
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(79, 86);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(420, 32);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(79, 138);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMensagem.Size = new System.Drawing.Size(420, 228);
            this.txtMensagem.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.Location = new System.Drawing.Point(79, 380);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(420, 45);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(597, 446);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Label lblResultado;
    }
}

